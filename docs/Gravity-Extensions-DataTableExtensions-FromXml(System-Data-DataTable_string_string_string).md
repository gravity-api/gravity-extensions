### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[DataTableExtensions](./Gravity-Extensions-DataTableExtensions.md 'Gravity.Extensions.DataTableExtensions')
## DataTableExtensions.FromXml(System.Data.DataTable, string, string, string) Method
Populates a [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') from a given XML (file or string).  
```csharp
public static System.Data.DataTable FromXml(this System.Data.DataTable dataTable, string source, string tableName, string filterExpression);
```
#### Parameters
<a name='Gravity-Extensions-DataTableExtensions-FromXml(System-Data-DataTable_string_string_string)-dataTable'></a>
`dataTable` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to populate to.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromXml(System-Data-DataTable_string_string_string)-source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
XML file or string to populate from.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromXml(System-Data-DataTable_string_string_string)-tableName'></a>
`tableName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the XML table to use for table mapping.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromXml(System-Data-DataTable_string_string_string)-filterExpression'></a>
`filterExpression` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].  
  
#### Returns
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') object that match the filter criteria.  
