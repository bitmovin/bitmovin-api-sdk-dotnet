using System;
using System.Collections;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Bitmovin.Api.Sdk.Common
{
    /// <summary>
    /// Contract resolver that excludes empty collections from serialization
    /// </summary>
    public class EmptyCollectionContractResolver : CamelCasePropertyNamesContractResolver
    {
        /// <summary>
        /// Creates a JSON property with custom serialization logic for empty collections
        /// </summary>
        /// <param name="member">The member info</param>
        /// <param name="memberSerialization">The member serialization type</param>
        /// <returns>The JSON property</returns>
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            Predicate<object> shouldSerialize = property.ShouldSerialize;
            property.ShouldSerialize = obj => (shouldSerialize == null || shouldSerialize(obj)) && !IsEmptyCollection(property, obj);
            return property;
        }

        private bool IsEmptyCollection(JsonProperty property, object target) {
            var value = property.ValueProvider.GetValue(target);
            if (value is ICollection collection && collection.Count == 0)
                return true;

            if (!typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                return false;

            var countProp = property.PropertyType.GetProperty("Count");
            if (countProp == null)
                return false;

            var count = (int)countProp.GetValue(value, null);
            return count == 0;
        } 
    }
}
