### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[HttpExtensions](./Gravity-Extensions-HttpExtensions.md 'Gravity.Extensions.HttpExtensions')
## HttpExtensions.ToObject&lt;T&gt;(System.Net.Http.HttpResponseMessage) Method
Deserialize [System.Net.Http.HttpResponseMessage.Content](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpResponseMessage.Content 'System.Net.Http.HttpResponseMessage.Content') into a given object type.  
```csharp
public static T ToObject<T>(this System.Net.Http.HttpResponseMessage message);
```
#### Type parameters
<a name='Gravity-Extensions-HttpExtensions-ToObject-T-(System-Net-Http-HttpResponseMessage)-T'></a>
`T`  
Expected object type  
  
#### Parameters
<a name='Gravity-Extensions-HttpExtensions-ToObject-T-(System-Net-Http-HttpResponseMessage)-message'></a>
`message` [System.Net.Http.HttpResponseMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage')  
[System.Net.Http.HttpResponseMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') to deserialize body from.  
  
#### Returns
[T](#Gravity-Extensions-HttpExtensions-ToObject-T-(System-Net-Http-HttpResponseMessage)-T 'Gravity.Extensions.HttpExtensions.ToObject&lt;T&gt;(System.Net.Http.HttpResponseMessage).T')  
Data Transfer Object of the provided type.  
