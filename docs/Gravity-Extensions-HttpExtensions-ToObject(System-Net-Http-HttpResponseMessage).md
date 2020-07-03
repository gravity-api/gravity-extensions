### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[HttpExtensions](./Gravity-Extensions-HttpExtensions.md 'Gravity.Extensions.HttpExtensions')
## HttpExtensions.ToObject(System.Net.Http.HttpResponseMessage) Method
Deserialize [System.Net.Http.HttpResponseMessage.Content](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpResponseMessage.Content 'System.Net.Http.HttpResponseMessage.Content') into a [Newtonsoft.Json.Linq.JObject](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Linq.JObject 'Newtonsoft.Json.Linq.JObject').  
```csharp
public static Newtonsoft.Json.Linq.JObject ToObject(this System.Net.Http.HttpResponseMessage message);
```
#### Parameters
<a name='Gravity-Extensions-HttpExtensions-ToObject(System-Net-Http-HttpResponseMessage)-message'></a>
`message` [System.Net.Http.HttpResponseMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage')  
[System.Net.Http.HttpResponseMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') to deserialize body from.  
  
#### Returns
[Newtonsoft.Json.Linq.JObject](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Linq.JObject 'Newtonsoft.Json.Linq.JObject')  
[Newtonsoft.Json.Linq.JObject](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Linq.JObject 'Newtonsoft.Json.Linq.JObject') instance.  
