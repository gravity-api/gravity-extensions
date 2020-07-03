### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[StringExtensions](./Gravity-Extensions-StringExtensions.md 'Gravity.Extensions.StringExtensions')
## StringExtensions.ToBase64(string, bool) Method
Converts a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to Base64.  
```csharp
public static string ToBase64(this string str, bool omitPaddaing=true);
```
#### Parameters
<a name='Gravity-Extensions-StringExtensions-ToBase64(string_bool)-str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to convert.  
  
<a name='Gravity-Extensions-StringExtensions-ToBase64(string_bool)-omitPaddaing'></a>
`omitPaddaing` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Replace all '=' chars in the string (defaults to true).  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Base64 representation of the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
