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
    /// SegmentsMediaInfo
    /// </summary>

    public class SegmentsMediaInfo : BasicMediaInfo
    {
        /// <summary>
        /// Path to segments.
        /// </summary>
        [JsonProperty(PropertyName = "segmentPath")]
        public string SegmentPath { get; set; }
        
        /// <summary>
        /// Id of the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }
        
        /// <summary>
        /// Id of the stream.
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        /// <summary>
        /// Id of the muxing.
        /// </summary>
        [JsonProperty(PropertyName = "muxingId")]
        public string MuxingId { get; set; }
        
        /// <summary>
        /// Id of the DRM.
        /// </summary>
        [JsonProperty(PropertyName = "drmId")]
        public string DrmId { get; set; }
        
        /// <summary>
        /// Number of the first segment. Default is 0.
        /// </summary>
        [JsonProperty(PropertyName = "startSegmentNumber")]
        public long? StartSegmentNumber { get; set; }
        
        /// <summary>
        /// Number of the last segment. Default is the last one that was encoded.
        /// </summary>
        [JsonProperty(PropertyName = "endSegmentNumber")]
        public long? EndSegmentNumber { get; set; }
    }

}
