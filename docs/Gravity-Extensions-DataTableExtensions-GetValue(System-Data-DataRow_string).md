### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[DataTableExtensions](./Gravity-Extensions-DataTableExtensions.md 'Gravity.Extensions.DataTableExtensions')
## DataTableExtensions.GetValue(System.Data.DataRow, string) Method
Get a value for a row by column name. If column does not exists, return null;  
```csharp
public static object GetValue(this System.Data.DataRow row, string column);
```
#### Parameters
<a name='Gravity-Extensions-DataTableExtensions-GetValue(System-Data-DataRow_string)-row'></a>
`row` [System.Data.DataRow](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataRow 'System.Data.DataRow')  
[System.Data.DataRow](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataRow 'System.Data.DataRow') to get from.  
  
<a name='Gravity-Extensions-DataTableExtensions-GetValue(System-Data-DataRow_string)-column'></a>
`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[System.Data.DataColumn.ColumnName](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataColumn.ColumnName 'System.Data.DataColumn.ColumnName') to get from.  
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
Data value or null if not found.  
