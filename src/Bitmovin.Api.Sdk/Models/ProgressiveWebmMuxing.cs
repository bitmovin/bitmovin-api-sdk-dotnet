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
    /// ProgressiveWebmMuxing
    /// </summary>

    public class ProgressiveWebmMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "PROGRESSIVE_WEBM";

        /// <summary>
        /// Name of the new Video
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <summary>
        /// Modifies the internal chunk length used for chunked encoding
        /// </summary>
        [JsonProperty(PropertyName = "internalChunkLength")]
        public InternalChunkLength InternalChunkLength { get; set; }
    }

}
