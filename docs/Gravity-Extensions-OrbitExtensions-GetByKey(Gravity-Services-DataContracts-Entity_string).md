### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[OrbitExtensions](./Gravity-Extensions-OrbitExtensions.md 'Gravity.Extensions.OrbitExtensions')
## OrbitExtensions.GetByKey(Gravity.Services.DataContracts.Entity, string) Method
Gets the first value from [Gravity.Services.DataContracts.Entity.EntityContentEntries](https://docs.microsoft.com/en-us/dotnet/api/Gravity.Services.DataContracts.Entity.EntityContentEntries 'Gravity.Services.DataContracts.Entity.EntityContentEntries') by it's key, null if not found.  
```csharp
public static string GetByKey(this Gravity.Services.DataContracts.Entity entity, string key);
```
#### Parameters
<a name='Gravity-Extensions-OrbitExtensions-GetByKey(Gravity-Services-DataContracts-Entity_string)-entity'></a>
`entity` [Gravity.Services.DataContracts.Entity](https://docs.microsoft.com/en-us/dotnet/api/Gravity.Services.DataContracts.Entity 'Gravity.Services.DataContracts.Entity')  
The [Gravity.Services.DataContracts.Entity](https://docs.microsoft.com/en-us/dotnet/api/Gravity.Services.DataContracts.Entity 'Gravity.Services.DataContracts.Entity') to search.  
  
<a name='Gravity-Extensions-OrbitExtensions-GetByKey(Gravity-Services-DataContracts-Entity_string)-key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The key to search by.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value found or null.  
