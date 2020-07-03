### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[DataTableExtensions](./Gravity-Extensions-DataTableExtensions.md 'Gravity.Extensions.DataTableExtensions')
## DataTableExtensions.Filter(System.Data.DataTable, string) Method
Gets a new [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') object that match the filter criteria.  
```csharp
public static System.Data.DataTable Filter(this System.Data.DataTable dataTable, string filterExpression);
```
#### Parameters
<a name='Gravity-Extensions-DataTableExtensions-Filter(System-Data-DataTable_string)-dataTable'></a>
`dataTable` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to filter.  
  
<a name='Gravity-Extensions-DataTableExtensions-Filter(System-Data-DataTable_string)-filterExpression'></a>
`filterExpression` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].  
  
#### Returns
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') object that match the filter criteria.  
