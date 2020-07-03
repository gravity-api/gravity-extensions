### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[DataTableExtensions](./Gravity-Extensions-DataTableExtensions.md 'Gravity.Extensions.DataTableExtensions')
## DataTableExtensions.FromCsv(System.Data.DataTable, string, string) Method
Populates a [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') from a given CSV (file or string).  
```csharp
public static System.Data.DataTable FromCsv(this System.Data.DataTable dataTable, string source, string filterExpression);
```
#### Parameters
<a name='Gravity-Extensions-DataTableExtensions-FromCsv(System-Data-DataTable_string_string)-dataTable'></a>
`dataTable` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to populate to.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromCsv(System-Data-DataTable_string_string)-source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
CSV file or string to populate from.  
  
<a name='Gravity-Extensions-DataTableExtensions-FromCsv(System-Data-DataTable_string_string)-filterExpression'></a>
`filterExpression` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].  
  
#### Returns
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') object that match the filter criteria.  
