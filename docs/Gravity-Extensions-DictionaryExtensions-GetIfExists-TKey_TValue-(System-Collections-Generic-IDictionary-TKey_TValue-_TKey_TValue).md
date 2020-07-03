### [Gravity.Extensions](./Gravity-Extensions.md 'Gravity.Extensions').[DictionaryExtensions](./Gravity-Extensions-DictionaryExtensions.md 'Gravity.Extensions.DictionaryExtensions')
## DictionaryExtensions.GetIfExists&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue) Method
Gets a value from a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') if exists or default value if not.  
```csharp
public static TValue GetIfExists<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, TValue altValue=default(TValue));
```
#### Type parameters
<a name='Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TKey'></a>
`TKey`  
The type of keys in the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TValue'></a>
`TValue`  
The type of values in the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
#### Parameters
<a name='Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-dictionary'></a>
`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TKey 'Gravity.Extensions.DictionaryExtensions.GetIfExists&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TValue 'Gravity.Extensions.DictionaryExtensions.GetIfExists&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to get value from.  
  
<a name='Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-key'></a>
`key` [TKey](#Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TKey 'Gravity.Extensions.DictionaryExtensions.GetIfExists&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')  
Key by which to get value.  
  
<a name='Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-altValue'></a>
`altValue` [TValue](#Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TValue 'Gravity.Extensions.DictionaryExtensions.GetIfExists&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
Value to return if not found  
  
#### Returns
[TValue](#Gravity-Extensions-DictionaryExtensions-GetIfExists-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue)-TValue 'Gravity.Extensions.DictionaryExtensions.GetIfExists&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
A value of the request type, or default value if not found.  
