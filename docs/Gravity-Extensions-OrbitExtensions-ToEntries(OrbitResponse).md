### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[OrbitExtensions](./Gravity-Extensions-OrbitExtensions.md 'Gravity.Extensions.OrbitExtensions')
## OrbitExtensions.ToEntries(OrbitResponse) Method
Flatten all [Gravity.Services.DataContracts.OrbitResponse.Extractions](https://docs.microsoft.com/en-us/dotnet/api/Gravity.Services.DataContracts.OrbitResponse.Extractions 'Gravity.Services.DataContracts.OrbitResponse.Extractions') into a list of entities entries.  
```csharp
public static System.Collections.Generic.IDictionary<string,string> ToEntries(this OrbitResponse orbitResponse);
```
#### Parameters
<a name='Gravity-Extensions-OrbitExtensions-ToEntries(OrbitResponse)-orbitResponse'></a>
`orbitResponse` [Gravity.Services.DataContracts.OrbitResponse](https://docs.microsoft.com/en-us/dotnet/api/Gravity.Services.DataContracts.OrbitResponse 'Gravity.Services.DataContracts.OrbitResponse')  
[Gravity.Services.DataContracts.OrbitResponse](https://docs.microsoft.com/en-us/dotnet/api/Gravity.Services.DataContracts.OrbitResponse 'Gravity.Services.DataContracts.OrbitResponse') to flatten.  
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A collection of entities entries.  
