### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[DataTableExtensions](./Gravity-Extensions-DataTableExtensions.md 'Gravity.Extensions.DataTableExtensions')
## DataTableExtensions.FromSqlDatabase(System.Data.DataTable, string, string, string) Method
Populates a [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') from a given SQL Database.  
```csharp
public static System.Data.DataTable FromSqlDatabase(this System.Data.DataTable dataTable, string connectionString, string tableName, string filterExpression);
```
#### Parameters
<a name='Gravity-Extensions-DataTableExtensions-FromSqlDatabase(System-Data-DataTable_string_string_string)-dataTable'></a>
`dataTable` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to populate to.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromSqlDatabase(System-Data-DataTable_string_string_string)-connectionString'></a>
`connectionString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The connection used to open the SQL Server database.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromSqlDatabase(System-Data-DataTable_string_string_string)-tableName'></a>
`tableName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to use for table mapping.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromSqlDatabase(System-Data-DataTable_string_string_string)-filterExpression'></a>
`filterExpression` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].  
  
#### Returns
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') object that match the filter criteria.  
