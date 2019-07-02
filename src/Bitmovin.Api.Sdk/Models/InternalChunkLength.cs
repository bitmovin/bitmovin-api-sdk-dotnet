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
    /// InternalChunkLength
    /// </summary>

    public class InternalChunkLength
    {
        /// <summary>
        /// Defines how the internal chunk length for encoding will be determined (required)
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public ChunkLengthMode? Mode { get; set; }
        
        /// <summary>
        /// Defines a custom internal chunk length in seconds to be used for encoding if mode is set to &#x60;CUSTOM&#x60;. Valid range is from 1 to 180 seconds
        /// </summary>
        [JsonProperty(PropertyName = "customChunkLength")]
        public double? CustomChunkLength { get; set; }
    }

}
