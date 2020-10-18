### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[ObjectExtensions](./Gravity-Extensions-ObjectExtensions.md 'Gravity.Extensions.ObjectExtensions')
## ObjectExtensions.ToJson(object, NamingStrategy) Method
Serializes the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') into a JSON string.  
```csharp
public static string ToJson(this object obj, NamingStrategy namingStrategy);
```
#### Parameters
<a name='Gravity-Extensions-ObjectExtensions-ToJson(object_NamingStrategy)-obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to serialize.  
  
<a name='Gravity-Extensions-ObjectExtensions-ToJson(object_NamingStrategy)-namingStrategy'></a>
`namingStrategy` [Newtonsoft.Json.Serialization.NamingStrategy](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Serialization.NamingStrategy 'Newtonsoft.Json.Serialization.NamingStrategy')  
Resolving how property names and dictionary keys are serialized.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A JSON string representation of the object.  
### Remarks
This method use [Newtonsoft.Json.Serialization.CamelCaseNamingStrategy](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Serialization.CamelCaseNamingStrategy 'Newtonsoft.Json.Serialization.CamelCaseNamingStrategy').  
