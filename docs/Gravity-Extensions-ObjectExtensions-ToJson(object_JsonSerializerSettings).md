### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[ObjectExtensions](./Gravity-Extensions-ObjectExtensions.md 'Gravity.Extensions.ObjectExtensions')
## ObjectExtensions.ToJson(object, JsonSerializerSettings) Method
Serializes the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') into a JSON string.  
```csharp
public static string ToJson(this object obj, JsonSerializerSettings settings);
```
#### Parameters
<a name='Gravity-Extensions-ObjectExtensions-ToJson(object_JsonSerializerSettings)-obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to serialize.  
  
<a name='Gravity-Extensions-ObjectExtensions-ToJson(object_JsonSerializerSettings)-settings'></a>
`settings` [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
Specifies the settings on a [Newtonsoft.Json.JsonSerializer](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializer 'Newtonsoft.Json.JsonSerializer') object.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A JSON string representation of the object.  
