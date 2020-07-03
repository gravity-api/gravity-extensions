/*
 * CHANGE LOG - keep only last 5 threads
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Gravity.Extensions
{
    /// <summary>
    /// Extensions for <see cref="object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        #region *** To JSON ***
        /// <summary>
        /// Serializes the specified <see cref="object"/> into a JSON string.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to serialize.</param>
        /// <returns>A JSON string representation of the object.</returns>
        /// <remarks>This method use <see cref="CamelCaseNamingStrategy"/>.</remarks>
        public static string ToJson(this object obj)
        {
            return DoToJson(obj, new CamelCaseNamingStrategy());
        }

        /// <summary>
        /// Serializes the specified <see cref="object"/> into a JSON string.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to serialize.</param>
        /// <param name="namingStrategy">Resolving how property names and dictionary keys are serialized.</param>
        /// <returns>A JSON string representation of the object.</returns>
        /// <remarks>This method use <see cref="CamelCaseNamingStrategy"/>.</remarks>
        public static string ToJson(this object obj, NamingStrategy namingStrategy)
        {
            return DoToJson(obj, namingStrategy);
        }

        /// <summary>
        /// Serializes the specified <see cref="object"/> into a JSON string.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to serialize.</param>
        /// <param name="settings">Specifies the settings on a <see cref="JsonSerializer"/> object.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson(this object obj, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(obj, settings);
        }

        private static string DoToJson(object obj, NamingStrategy namingStrategy)
        {
            // get camel-case resolver
            var resolver = new DefaultContractResolver
            {
                NamingStrategy = namingStrategy
            };

            // initialize settings
            var settings = new JsonSerializerSettings { ContractResolver = resolver };

            // get body
            return JsonConvert.SerializeObject(obj, settings);
        }
        #endregion

        /// <summary>
        /// Creates a new copy of this <see cref="object"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="object"/> type to clone.</typeparam>
        /// <param name="obj"><see cref="object"/> to clone.</param>
        /// <returns>A new <see cref="object"/> copy (with a different memory address).</returns>
        public static T Clone<T>(this T obj)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
        }
    }
}