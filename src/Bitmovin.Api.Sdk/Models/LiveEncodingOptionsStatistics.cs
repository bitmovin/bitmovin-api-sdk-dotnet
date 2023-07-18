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
    /// LiveEncodingOptionsStatistics
    /// </summary>
    public class LiveEncodingOptionsStatistics
    {
        /// <summary>
        /// The ID of the encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// Live option units used (required)
        /// </summary>
        [JsonProperty(PropertyName = "unitsUsed")]
        public double? UnitsUsed { get; internal set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LiveOptionsType? Type { get; set; }
    }
}
