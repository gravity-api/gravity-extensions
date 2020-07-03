### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[CollectionExtensions](./Gravity-Extensions-CollectionExtensions.md 'Gravity.Extensions.CollectionExtensions')
## CollectionExtensions.DistinctBy&lt;TSource,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;) Method
Returns all distinct elements of the given source, where "distinctness"  
is determined via a projection and the default equality comparer for the projected type  
```csharp
public static System.Collections.Generic.IEnumerable<TSource> DistinctBy<TSource,TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
```
#### Type parameters
<a name='Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TSource'></a>
`TSource`  
Type of the source sequence.  
  
<a name='Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TKey'></a>
`TKey`  
Type of the projected element.  
  
#### Parameters
<a name='Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](#Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TSource 'Gravity.Extensions.CollectionExtensions.DistinctBy&lt;TSource,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Source sequence.  
  
<a name='Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-keySelector'></a>
`keySelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](#Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TSource 'Gravity.Extensions.CollectionExtensions.DistinctBy&lt;TSource,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](#Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TKey 'Gravity.Extensions.CollectionExtensions.DistinctBy&lt;TSource,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Projection for determining "distinctness".  
  
<a name='Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](#Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TKey 'Gravity.Extensions.CollectionExtensions.DistinctBy&lt;TSource,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
The equality comparer to use to determine whether or not keys are equal. If null, the default equality comparer for `TSource` is used.  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](#Gravity-Extensions-CollectionExtensions-DistinctBy-TSource_TKey-(System-Collections-Generic-IEnumerable-TSource-_System-Func-TSource_TKey-_System-Collections-Generic-IEqualityComparer-TKey-)-TSource 'Gravity.Extensions.CollectionExtensions.DistinctBy&lt;TSource,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence consisting of distinct elements from the source sequence, comparing them by the specified key projection.  
### Remarks
This operator uses deferred execution and streams the results, although  
a set of already-seen keys is retained. If a key is seen multiple times,  
only the first element with that key is returned.  
