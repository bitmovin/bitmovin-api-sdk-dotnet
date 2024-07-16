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
    /// Keyframe
    /// </summary>
    public class Keyframe : BitmovinResource
    {
        /// <summary>
        /// Time in seconds where the keyframe should be inserted (required)
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }
    }
}
