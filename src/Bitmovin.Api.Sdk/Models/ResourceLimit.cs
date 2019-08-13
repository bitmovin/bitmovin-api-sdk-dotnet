using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ResourceLimit
    /// </summary>

    public class ResourceLimit
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <summary>
        /// Specifies the remaining limit value for limits divided to sub-organizations. This property is returned only for parent organizations and only for mentioned limits.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveValue")]
        public string EffectiveValue { get; internal set; }
    }

}
