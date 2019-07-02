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
    /// AudioConfiguration
    /// </summary>

    public class AudioConfiguration : CodecConfiguration
    {
        /// <summary>
        /// Target bitrate for the encoded audio in bps (required)
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; set; }
        
        /// <summary>
        /// Audio sampling rate Hz
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }
    }

}
