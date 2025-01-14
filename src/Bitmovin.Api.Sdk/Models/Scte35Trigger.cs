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
    /// Scte35Trigger
    /// </summary>
    public class Scte35Trigger : BitmovinResponse
    {
        /// <summary>
        /// Time in seconds where the SCTE 35 trigger should be inserted (required)
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }

        /// <summary>
        /// The base 64 encoded data for the SCTE trigger (required)
        /// </summary>
        [JsonProperty(PropertyName = "base64EncodedMetadata")]
        public string Base64EncodedMetadata { get; set; }
    }
}
