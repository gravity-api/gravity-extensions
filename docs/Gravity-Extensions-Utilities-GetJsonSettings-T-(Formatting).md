### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[Utilities](./Gravity-Extensions-Utilities.md 'Gravity.Extensions.Utilities')
## Utilities.GetJsonSettings&lt;T&gt;(Formatting) Method
Gets [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') based on [Newtonsoft.Json.Serialization.NamingStrategy](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Serialization.NamingStrategy 'Newtonsoft.Json.Serialization.NamingStrategy').  
```csharp
public static JsonSerializerSettings GetJsonSettings<T>(Formatting formatting=1);
```
#### Type parameters
<a name='Gravity-Extensions-Utilities-GetJsonSettings-T-(Formatting)-T'></a>
`T`  
[Newtonsoft.Json.Serialization.NamingStrategy](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Serialization.NamingStrategy 'Newtonsoft.Json.Serialization.NamingStrategy') strategy type.  
  
#### Parameters
<a name='Gravity-Extensions-Utilities-GetJsonSettings-T-(Formatting)-formatting'></a>
`formatting` [Newtonsoft.Json.Formatting](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Formatting 'Newtonsoft.Json.Formatting')  
  
#### Returns
[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') applied on a [Newtonsoft.Json.JsonSerializer](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializer 'Newtonsoft.Json.JsonSerializer') object.  
