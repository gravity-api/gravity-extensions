/*
 * CHANGE LOG - keep only last 5 threads
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace Gravity.Extensions
{
    /// <summary>
    /// Extensions for <see cref="DataTable"/> and <see cref="System.Data"/> objects.
    /// </summary>
    public static class DataTableExtensions
    {
        /// <summary>
        /// Gets a new <see cref="DataTable"/> object that match the filter criteria.
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to filter.</param>
        /// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        public static DataTable Filter(this DataTable dataTable, string filterExpression)
        {
            return dataTable.DoFilter(filterExpression);
        }

        #region *** To Dictionary  ***
        /// <summary>
        /// Gets a <see cref="IDictionary{TKey, TValue}"/> representation of <see cref="DataTable"/> object.
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate from.</param>
        /// <returns>A <see cref="IDictionary{TKey, TValue}"/> representation of <see cref="DataTable"/> object.</returns>
        public static IEnumerable<IDictionary<string, object>> ToDictionary(this DataTable dataTable)
        {
            return dataTable.Rows.Cast<DataRow>().Select(DoToDictionary);
        }

        /// <summary>
        /// Gets a <see cref="IDictionary{TKey, TValue}"/> representation of <see cref="DataRow"/> object.
        /// </summary>
        /// <param name="dataRow"><see cref="DataTable"/> to populate from.</param>
        /// <returns>A <see cref="IDictionary{TKey, TValue}"/> representation of <see cref="DataRow"/> object.</returns>
        public static IDictionary<string, object> ToDictionary(this DataRow dataRow)
        {
            return dataRow.DoToDictionary();
        }
        #endregion

        #region *** Get Value      ***
        /// <summary>
        /// Get a value for a row by column name. If column does not exists, return null;
        /// </summary>
        /// <param name="row"><see cref="DataRow"/> to get from.</param>
        /// <param name="column"><see cref="DataColumn.ColumnName"/> to get from.</param>
        /// <returns>Data value or null if not found.</returns>
        public static object GetValue(this DataRow row, string column)
            => row.Table.Columns.Contains(column) ? row[column] : null;

        /// <summary>
        /// Get a value for a row by column name. If column does not exists, return null;
        /// </summary>
        /// <typeparam name="T">The type of the request value.</typeparam>
        /// <param name="row"><see cref="DataRow"/> to get from.</param>
        /// <param name="column"><see cref="DataColumn.ColumnName"/> to get from.</param>
        /// <returns>Data value or null if not found.</returns>
        public static object GetValue<T>(this DataRow row, string column)
        {
            if (row.Table.Columns.Contains(column))
            {
                return (T)row[column];
            }
            return null;
        }
        #endregion

        /// <summary>
        /// Merge a collection of <see cref="DataTable"/> into a single <see cref="DataTable"/> object.
        /// </summary>
        /// <param name="tables">A collection of <see cref="DataTable"/> to merge from</param>
        /// <returns>A single, merged <see cref="DataTable"/> object.</returns>
        public static DataTable Merge(this IEnumerable<DataTable> tables)
        {
            // exit conditions
            if (!tables.Any())
            {
                return default;
            }

            // extract all columns
            var onTables = new List<DataTable>();
            onTables.AddRange(tables);
            var columns = onTables.SelectMany(i => i.Columns.Cast<DataColumn>()).Select(i => i.ColumnName);

            // create new table and apply aggregated columns
            var dataTable = new DataTable();
            foreach (var column in columns)
            {
                dataTable.Columns.Add(column);
            }

            // apply rows from all tables (will apply only if column is valid)
            foreach (var table in onTables)
            {
                var index = 0;
                foreach (DataRow i in table.Rows)
                {
                    // new row conditions
                    if (index > dataTable.Rows.Count - 1)
                    {
                        var mergedRow = dataTable.NewRow();
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            mergedRow[table.Columns[j].ColumnName] = $"{table.Rows[index][j]}";
                        }
                        dataTable.Rows.Add(mergedRow);
                    }
                    // have row
                    else
                    {
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            dataTable.Rows[index][table.Columns[j].ColumnName] = $"{table.Rows[index][j]}";
                        }
                    }
                    index++;
                }
            }

            // complete pipeline
            return dataTable;
        }

        /// <summary>
        /// Populates a <see cref="DataTable"/> from a given JSON (file or string).
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate to.</param>
        /// <param name="source">JSON file or string to populate from.</param>
        /// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        public static DataTable FromJson(this DataTable dataTable, string source, string filterExpression)
        {
            // exit conditions
            DataSourceCompliance(source: source, needRepository: false, repository: string.Empty);

            // normalize filter
            filterExpression = (string.IsNullOrEmpty(filterExpression)) ? string.Empty : filterExpression;

            // if source is a file, load from file
            if (File.Exists(source))
            {
                source = File.ReadAllText(source);
            }

            // load JToken
            var token = JToken.Parse(source);

            // exit conditions
            if (!(token is JArray))
            {
                return dataTable;
            }
            if (((JArray)token).Count == 0)
            {
                return dataTable;
            }

            // get data-table
            dataTable = JsonConvert.DeserializeObject<DataTable>(source);
            return dataTable.DoFilter(filterExpression);
        }

        #region *** From CSV       ***
        /// <summary>
        /// Populates a <see cref="DataTable"/> from a given CSV (file or string).
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate to.</param>
        /// <param name="source">CSV file or string to populate from.</param>
        /// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        public static DataTable FromCsv(this DataTable dataTable, string source, string filterExpression)
        {
            // exit conditions
            DataSourceCompliance(source: source, needRepository: false, repository: string.Empty);

            // normalize filter
            filterExpression = (string.IsNullOrEmpty(filterExpression)) ? string.Empty : filterExpression;

            // if source is a file, load from file
            if (File.Exists(source))
            {
                source = File.ReadAllText(source);
            }

            using (var stringReader = new StringReader(source))
            {
                // process headers
                var headersLine = stringReader.ReadLine();
                var numberOfColumns = AddHeaders(dataTable, headersLine);

                // exit conditions
                if (numberOfColumns == 0)
                {
                    return dataTable;
                }

                // process lines
                const StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries;
                var splitter = new[] { Environment.NewLine, "\n", "\t", "\r" };
                var lines = stringReader.ReadToEnd().Split(splitter, options);
                for (int i = 0; i < lines.Length; i++)
                {
                    AddLine(dataTable, lines[i], numberOfColumns);
                }
            }

            // return populated table
            return dataTable.DoFilter(filterExpression);
        }

        // add comma-delimited headers to a data-table
        private static int AddHeaders(DataTable dataTable, string headersLins)
        {
            var headers = headersLins?.Split(',');
            if (headers == null)
            {
                return 0;
            }
            foreach (var header in headers)
            {
                dataTable.Columns.Add(header);
            }
            return headers.Length;
        }

        // add comma-delimited line to a data-table
        private static void AddLine(DataTable dataTable, string line, int numberOfColumns)
        {
            // split line
            const string SPLITTER = ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
            var rows = Regex.Split(line, SPLITTER);

            // create new table-row into which to populate line
            var dataRow = dataTable.NewRow();

            // populate line
            for (var j = 0; j < numberOfColumns; j++)
            {
                if (rows.Length - 1 < j)
                {
                    dataRow[j] = null;
                    continue;
                }
                dataRow[j] = rows[j];
            }

            // add row
            dataTable.Rows.Add(dataRow);
        }
        #endregion

        /// <summary>
        /// Populates a <see cref="DataTable"/> from a given SQL Database.
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate to.</param>
        /// <param name="connectionString">The connection used to open the SQL Server database.</param>
        /// <param name="tableName">The name of the <see cref="DataTable"/> to use for table mapping.</param>
        /// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        public static DataTable FromSqlDatabase(this DataTable dataTable, string connectionString, string tableName, string filterExpression)
        {
            // exit conditions
            DataSourceCompliance(source: connectionString, needRepository: true, repository: tableName);

            // normalize filter
            filterExpression = (string.IsNullOrEmpty(filterExpression)) ? string.Empty : filterExpression;

            // parse query
            using var sqlConnection = new SqlConnection(connectionString);

            // open connection
            sqlConnection.Open();

            // set SQL data-adapter
            var command = new SqlCommand("sp_executesql @SQLString", sqlConnection);
            command.Parameters.AddWithValue(parameterName: "@SQLString", value: $"SELECT * FROM {tableName}");
            var sqlDataAdapter = new SqlDataAdapter(selectCommand: command);

            // populate data-table
            sqlDataAdapter.Fill(dataTable);
            sqlDataAdapter.Dispose();

            // return populated data
            return dataTable.DoFilter(filterExpression);
        }

        #region *** From Mark Down ***
        /// <summary>
        /// Populates a <see cref="DataTable"/> from a given .MD (file or string).
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate to.</param>
        /// <param name="source">.MD file or string to populate from.</param>
        /// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Designed to be used as an indepndent static.")]
        public static DataTable FromMarkDown(this DataTable dataTable, string source, string filterExpression)
        {
            return DoFromMarkDown(source, filterExpression);
        }

        /// <summary>
        /// Populates a <see cref="DataTable"/> from a given .MD (file or string).
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate to.</param>
        /// <param name="source">.MD file or string to populate from.</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Designed to be used as an indepndent static.")]
        public static DataTable FromMarkDown(this DataTable dataTable, string source)
        {
            return DoFromMarkDown(source, filterExpression: string.Empty);
        }

        private static DataTable DoFromMarkDown(string source, string filterExpression)
        {
            // exit conditions
            DataSourceCompliance(source: source, needRepository: false, repository: string.Empty);

            // normalize filter
            filterExpression = (string.IsNullOrEmpty(filterExpression)) ? string.Empty : filterExpression;

            // if source is a file, load from file
            if (File.Exists(source))
            {
                source = File.ReadAllText(source);
            }

            // split into lines            
            var lines = source
                .SplitByLines()
                .Where(i => !Regex.IsMatch(input: i, pattern: @"^(\|-+)+\|?$") && !string.IsNullOrEmpty(i))
                .ToArray();

            // exit conditions
            if (lines.Length == 1)
            {
                return new DataTable();
            }

            // get headers
            var headers = SplitMarkdownTable(lines[0]);

            // get lines
            var rows = new List<IEnumerable<string>> { headers };
            for (int i = 1; i < lines.Length; i++)
            {
                var row = SplitMarkdownTable(lines[i]);
                rows.Add(row);
            }

            // table
            var onDataTable = ToTable(rows);
            return DoFilter(dataTable: onDataTable, filterExpression);
        }

        private static IEnumerable<string> SplitMarkdownTable(string line)
        {
            // build
            line = line.Trim()[1..line.LastIndexOf("|")];

            // get
            return Regex
                .Split(line, @"\|+(:)?")
                .Select(i => string.IsNullOrWhiteSpace(i) ? string.Empty : i.Trim());
        }

        private static DataTable ToTable(IEnumerable<IEnumerable<string>> rows)
        {
            var dataTable = new DataTable();

            // add headers
            foreach (var header in rows.ElementAt(0))
            {
                dataTable.Columns.Add(header);
            }
            // add rows
            for (int i = 1; i < rows.Count(); i++)
            {
                var dataRow = dataTable.NewRow();
                for (int j = 0; j < rows.ElementAt(i).Count(); j++)
                {
                    dataRow[j] = rows.ElementAt(i).ElementAt(j);
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
        #endregion

        /// <summary>
        /// Populates a <see cref="DataTable"/> from a given XML (file or string).
        /// </summary>
        /// <param name="dataTable"><see cref="DataTable"/> to populate to.</param>
        /// <param name="source">XML file or string to populate from.</param>
        /// <param name="tableName">The name of the XML table to use for table mapping.</param>
        /// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
        /// <returns><see cref="DataTable"/> object that match the filter criteria.</returns>
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Designed to be used as an indepndent static.")]
        public static DataTable FromXml(this DataTable dataTable, string source, string tableName, string filterExpression)
        {
            // exit conditions
            DataSourceCompliance(source: source, needRepository: true, repository: tableName);

            // normalize filter
            filterExpression = (string.IsNullOrEmpty(filterExpression)) ? string.Empty : filterExpression;

            // if source is a file, load from file
            if (File.Exists(source))
            {
                source = File.ReadAllText(source);
            }

            // exit condition
            if (!source.IsXml())
            {
                throw new ArgumentException("the xml provided is not a valid xml string", nameof(source));
            }

            // populate data-table
            using var xmlReader = XmlReader.Create(new StringReader(source));
            using var dataSet = new DataSet();

            // load xml as data-table
            dataSet.ReadXml(xmlReader);

            // return populated data-table
            return dataSet.Tables[tableName].DoFilter(filterExpression);
        }

        // throws if data source is not valid
        private static void DataSourceCompliance(string source, bool needRepository, string repository)
        {
            // exit conditions
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("You must provide a valid data source.", nameof(source));
            }

            // exit conditions
            if (string.IsNullOrEmpty(repository) && needRepository)
            {
                throw new ArgumentException("You must provide a valid data repository.", nameof(repository));
            }
        }

        // UTILITIES
        // filter data table object
        private static DataTable DoFilter(this DataTable dataTable, string filterExpression)
        {
            // exit conditions
            if (filterExpression.Length == 0)
            {
                return dataTable;
            }

            // filter data-table
            var rows = dataTable.Select(filterExpression);

            // create new data-table instance
            var fDataTable = dataTable.Clone();

            // add filtered rows
            foreach (DataRow row in rows)
            {
                fDataTable.ImportRow(row);
            }

            // return new data-table
            return fDataTable;
        }

        // convert data row to dictionary
        private static IDictionary<string, object> DoToDictionary(this DataRow dataRow) => dataRow
            .Table
            .Columns
            .Cast<DataColumn>()
            .ToDictionary(key => key.ColumnName, str => dataRow[str.ColumnName]);
    }
}