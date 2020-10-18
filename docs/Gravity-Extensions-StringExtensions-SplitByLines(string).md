### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[StringExtensions](./Gravity-Extensions-StringExtensions.md 'Gravity.Extensions.StringExtensions')
## StringExtensions.SplitByLines(string) Method
Splits a given string by new lines and cleans up any empty lines and trim the substrings.  
```csharp
public static System.Collections.Generic.IEnumerable<string> SplitByLines(this string str);
```
#### Parameters
<a name='Gravity-Extensions-StringExtensions-SplitByLines(string)-str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to split.  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An array whose elements contain the substrings from this instance that are delimited by one or more characters in separator.  
