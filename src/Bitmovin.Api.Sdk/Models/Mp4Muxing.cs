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
    /// Mp4Muxing
    /// </summary>

    public class Mp4Muxing : Muxing
    {
        /// <summary>
        /// Name of the new Video
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <summary>
        ///  Duration of fragments in milliseconds. Required for Fragmented MP4 Muxing (for Smooth Streaming or DASH On-Demand). Not setting this will result in unfragmented mp4.
        /// </summary>
        [JsonProperty(PropertyName = "fragmentDuration")]
        public int? FragmentDuration { get; set; }
        
        /// <summary>
        /// TimeCode
        /// </summary>
        [JsonProperty(PropertyName = "timeCode")]
        public TimeCode TimeCode { get; set; }
        
        /// <summary>
        /// FragmentedMP4MuxingManifestType
        /// </summary>
        [JsonProperty(PropertyName = "fragmentedMP4MuxingManifestType")]
        public FragmentedMp4MuxingManifestType? FragmentedMP4MuxingManifestType { get; set; }
        
        /// <summary>
        /// Modifies the internal chunk length used for chunked encoding
        /// </summary>
        [JsonProperty(PropertyName = "internalChunkLength")]
        public InternalChunkLength InternalChunkLength { get; set; }
    }

}
