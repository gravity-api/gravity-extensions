### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[CollectionExtensions](./Gravity-Extensions-CollectionExtensions.md 'Gravity.Extensions.CollectionExtensions')
## CollectionExtensions.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int) Method
Splits [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') into smaller collections of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> Split<T>(this System.Collections.Generic.IEnumerable<T> source, int itemsPerSet);
```
#### Type parameters
<a name='Gravity-Extensions-CollectionExtensions-Split-T-(System-Collections-Generic-IEnumerable-T-_int)-T'></a>
`T`  
The type of objects to enumerate.  
  
#### Parameters
<a name='Gravity-Extensions-CollectionExtensions-Split-T-(System-Collections-Generic-IEnumerable-T-_int)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Gravity-Extensions-CollectionExtensions-Split-T-(System-Collections-Generic-IEnumerable-T-_int)-T 'Gravity.Extensions.CollectionExtensions.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Source [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
  
<a name='Gravity-Extensions-CollectionExtensions-Split-T-(System-Collections-Generic-IEnumerable-T-_int)-itemsPerSet'></a>
`itemsPerSet` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Number of items per set.  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Gravity-Extensions-CollectionExtensions-Split-T-(System-Collections-Generic-IEnumerable-T-_int)-T 'Gravity.Extensions.CollectionExtensions.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of smaller [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
