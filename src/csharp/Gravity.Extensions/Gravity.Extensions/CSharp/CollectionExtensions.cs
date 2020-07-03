/*
 * CHANGE LOG - keep only last 5 threads
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gravity.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEnumerable{T}"/> and <see cref="System.Collections"/> objects.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Tries to add a range of items to a <see cref="List{T}"/> list object.
        /// </summary>
        /// <typeparam name="T">The type of the list objects.</typeparam>
        /// <param name="list">The <see cref="List{T}"/> to add items to.</param>
        /// <param name="range">A collection of items to add.</param>
        /// <returns><see cref="bool.TrueString"/> if successful <see cref="bool.FalseString"/> if not.</returns>
        public static bool TryAddRange<T>(this List<T> list, IEnumerable<T> range)
        {
            if (range?.Any() != true)
            {
                return false;
            }
            list.AddRange(range);
            return true;
        }

        /// <summary>
        /// Splits <see cref="IEnumerable{T}"/> into smaller collections of <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of objects to enumerate.</typeparam>
        /// <param name="source">Source <see cref="IEnumerable{T}"/>.</param>
        /// <param name="itemsPerSet">Number of items per set.</param>
        /// <returns>A collection of smaller <see cref="IEnumerable{T}"/>.</returns>
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> source, int itemsPerSet)
        {
            var sourceList = source as List<T> ?? source.ToList();
            for (var index = 0; index < sourceList.Count; index += itemsPerSet)
            {
                yield return sourceList.Skip(index).Take(itemsPerSet);
            }
        }

        #region *** DistinctBy ***
        /// <summary>
        /// Returns all distinct elements of the given source, where "distinctness"
        /// is determined via a projection and the default equality comparer for the projected type
        /// </summary>
        ///
        /// <typeparam name="TSource">Type of the source sequence.</typeparam>
        /// <typeparam name="TKey">Type of the projected element.</typeparam>
        /// <param name="source">Source sequence.</param>
        /// <param name="keySelector">Projection for determining "distinctness".</param>
        /// <returns>A sequence consisting of distinct elements from the source sequence, comparing them by the specified key projection.</returns>
        ///
        /// <remarks>
        /// This operator uses deferred execution and streams the results, although
        /// a set of already-seen keys is retained. If a key is seen multiple times,
        /// only the first element with that key is returned.
        /// </remarks>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return DoDistinctBy(source, keySelector, null);
        }

        /// <summary>
        /// Returns all distinct elements of the given source, where "distinctness"
        /// is determined via a projection and the default equality comparer for the projected type
        /// </summary>
        ///
        /// <typeparam name="TSource">Type of the source sequence.</typeparam>
        /// <typeparam name="TKey">Type of the projected element.</typeparam>
        /// <param name="source">Source sequence.</param>
        /// <param name="keySelector">Projection for determining "distinctness".</param>
        /// <param name="comparer">The equality comparer to use to determine whether or not keys are equal. If null, the default equality comparer for <c>TSource</c> is used.</param>
        /// <returns>A sequence consisting of distinct elements from the source sequence, comparing them by the specified key projection.</returns>
        ///
        /// <remarks>
        /// This operator uses deferred execution and streams the results, although
        /// a set of already-seen keys is retained. If a key is seen multiple times,
        /// only the first element with that key is returned.
        /// </remarks>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
            this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            return DoDistinctBy(source, keySelector, comparer);
        }

        private static IEnumerable<TSource> DoDistinctBy<TSource, TKey>(
            IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));

            return _(); IEnumerable<TSource> _()
            {
                var knownKeys = new HashSet<TKey>(comparer);
                foreach (var element in source)
                {
                    if (knownKeys.Add(keySelector(element)))
                    {
                        yield return element;
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Parse a collection strings into a collection of integers.
        /// </summary>
        /// <param name="collection">A collection of strings to parse.</param>
        /// <returns>A collection of integers</returns>
        /// <remarks>If the string object cannot be parsed it will be ignored and will not be returned.</remarks>
        public static IEnumerable<int> AsNumbers(this IEnumerable<string> collection)
        {
            var list = new List<int>();
            foreach (var key in collection)
            {
                var isParse = int.TryParse(key, out int keyOut);
                if (!isParse)
                {
                    continue;
                }
                list.Add(keyOut);
            }
            return list;
        }
    }
}