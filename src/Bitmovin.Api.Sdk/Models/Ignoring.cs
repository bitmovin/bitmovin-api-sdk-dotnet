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
    /// Ignoring
    /// </summary>

    public class Ignoring
    {
        /// <summary>
        /// IgnoredBy
        /// </summary>
        [JsonProperty(PropertyName = "ignoredBy")]
        public IgnoredBy IgnoredBy { get; internal set; }
        
        /// <summary>
        /// Describes why ignoredBy has been set to its current value.
        /// </summary>
        [JsonProperty(PropertyName = "ignoredByDescription")]
        public string IgnoredByDescription { get; internal set; }
    }

}
