### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[CollectionExtensions](./Gravity-Extensions-CollectionExtensions.md 'Gravity.Extensions.CollectionExtensions')
## CollectionExtensions.AsNumbers(System.Collections.Generic.IEnumerable&lt;string&gt;) Method
Parse a collection strings into a collection of integers.  
```csharp
public static System.Collections.Generic.IEnumerable<int> AsNumbers(this System.Collections.Generic.IEnumerable<string> collection);
```
#### Parameters
<a name='Gravity-Extensions-CollectionExtensions-AsNumbers(System-Collections-Generic-IEnumerable-string-)-collection'></a>
`collection` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of strings to parse.  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of integers  
### Remarks
If the string object cannot be parsed it will be ignored and will not be returned.  
