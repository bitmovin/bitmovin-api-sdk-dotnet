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
    /// BroadcastTsMuxing
    /// </summary>

    public class BroadcastTsMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "BROADCAST_TS";

        /// <summary>
        /// Length of the segments in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }
        
        /// <summary>
        /// Name of the new Video
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <summary>
        /// Configuration
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public BroadcastTsMuxingConfiguration Configuration { get; set; }
        
        /// <summary>
        /// Modifies the internal chunk length used for chunked encoding
        /// </summary>
        [JsonProperty(PropertyName = "internalChunkLength")]
        public InternalChunkLength InternalChunkLength { get; set; }
    }

}
