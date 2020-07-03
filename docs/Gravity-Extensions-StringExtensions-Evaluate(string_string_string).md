### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[StringExtensions](./Gravity-Extensions-StringExtensions.md 'Gravity.Extensions.StringExtensions')
## StringExtensions.Evaluate(string, string, string) Method
Evaluates if source [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') meets a logical condition against a target [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
```csharp
public static bool Evaluate(this string source, string operation, string target);
```
#### Parameters
<a name='Gravity-Extensions-StringExtensions-Evaluate(string_string_string)-source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Source [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
  
<a name='Gravity-Extensions-StringExtensions-Evaluate(string_string_string)-operation'></a>
`operation` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Operation to execute. Check 'About Comparison Operators Powershell' for more information.  
  
<a name='Gravity-Extensions-StringExtensions-Evaluate(string_string_string)-target'></a>
`target` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Target [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if condition met. False if not.  
