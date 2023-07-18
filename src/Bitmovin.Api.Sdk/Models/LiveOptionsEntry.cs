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
    /// LiveOptionsEntry
    /// </summary>
    public class LiveOptionsEntry
    {
        /// <summary>
        /// Live option units used (required)
        /// </summary>
        [JsonProperty(PropertyName = "unitsUsed")]
        public long? UnitsUsed { get; internal set; }
    }
}
