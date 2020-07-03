### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[Utilities](./Gravity-Extensions-Utilities.md 'Gravity.Extensions.Utilities')
## Utilities.GetJsonSettings&lt;T&gt;(Newtonsoft.Json.Formatting) Method
Gets [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') based on [Newtonsoft.Json.Serialization.NamingStrategy](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Serialization.NamingStrategy 'Newtonsoft.Json.Serialization.NamingStrategy').  
```csharp
public static Newtonsoft.Json.JsonSerializerSettings GetJsonSettings<T>(Newtonsoft.Json.Formatting formatting=Newtonsoft.Json.Formatting.Indented);
```
#### Type parameters
<a name='Gravity-Extensions-Utilities-GetJsonSettings-T-(Newtonsoft-Json-Formatting)-T'></a>
`T`  
[Newtonsoft.Json.Serialization.NamingStrategy](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Serialization.NamingStrategy 'Newtonsoft.Json.Serialization.NamingStrategy') strategy type.  
  
#### Parameters
<a name='Gravity-Extensions-Utilities-GetJsonSettings-T-(Newtonsoft-Json-Formatting)-formatting'></a>
`formatting` [Newtonsoft.Json.Formatting](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Formatting 'Newtonsoft.Json.Formatting')  
  
#### Returns
[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') applied on a [Newtonsoft.Json.JsonSerializer](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializer 'Newtonsoft.Json.JsonSerializer') object.  
