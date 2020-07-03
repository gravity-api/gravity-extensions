### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[CollectionExtensions](./Gravity-Extensions-CollectionExtensions.md 'Gravity.Extensions.CollectionExtensions')
## CollectionExtensions.TryAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;) Method
Tries to add a range of items to a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') list object.  
```csharp
public static bool TryAddRange<T>(this System.Collections.Generic.List<T> list, System.Collections.Generic.IEnumerable<T> range);
```
#### Type parameters
<a name='Gravity-Extensions-CollectionExtensions-TryAddRange-T-(System-Collections-Generic-List-T-_System-Collections-Generic-IEnumerable-T-)-T'></a>
`T`  
The type of the list objects.  
  
#### Parameters
<a name='Gravity-Extensions-CollectionExtensions-TryAddRange-T-(System-Collections-Generic-List-T-_System-Collections-Generic-IEnumerable-T-)-list'></a>
`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](#Gravity-Extensions-CollectionExtensions-TryAddRange-T-(System-Collections-Generic-List-T-_System-Collections-Generic-IEnumerable-T-)-T 'Gravity.Extensions.CollectionExtensions.TryAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') to add items to.  
  
<a name='Gravity-Extensions-CollectionExtensions-TryAddRange-T-(System-Collections-Generic-List-T-_System-Collections-Generic-IEnumerable-T-)-range'></a>
`range` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Gravity-Extensions-CollectionExtensions-TryAddRange-T-(System-Collections-Generic-List-T-_System-Collections-Generic-IEnumerable-T-)-T 'Gravity.Extensions.CollectionExtensions.TryAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of items to add.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[System.Boolean.TrueString](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean.TrueString 'System.Boolean.TrueString') if successful [System.Boolean.FalseString](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean.FalseString 'System.Boolean.FalseString') if not.  
