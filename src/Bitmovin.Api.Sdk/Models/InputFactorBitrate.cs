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
    /// InputFactorBitrate
    /// </summary>
    public class InputFactorBitrate
    {
        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public long? Value { get; set; }

        /// <summary>
        /// Factor
        /// </summary>
        [JsonProperty(PropertyName = "factor")]
        public decimal? Factor { get; set; }
    }
}
