### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[StringExtensions](./Gravity-Extensions-StringExtensions.md 'Gravity.Extensions.StringExtensions')
## StringExtensions.FromTable(string, System.Data.DataTable) Method
Replicates string for each [System.Data.DataRow](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataRow 'System.Data.DataRow') and replace all {{column-name}} with  
the actual data from the column.  
```csharp
public static System.Collections.Generic.IEnumerable<string> FromTable(this string str, System.Data.DataTable dataTable);
```
#### Parameters
<a name='Gravity-Extensions-StringExtensions-FromTable(string_System-Data-DataTable)-str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to populate by.  
  
<a name='Gravity-Extensions-StringExtensions-FromTable(string_System-Data-DataTable)-dataTable'></a>
`dataTable` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')  
[System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to get data from.  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), for each [System.Data.DataRow](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataRow 'System.Data.DataRow').  
