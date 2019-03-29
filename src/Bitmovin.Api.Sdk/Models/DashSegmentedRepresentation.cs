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
    /// DashSegmentedRepresentation
    /// </summary>

    public class DashSegmentedRepresentation : DashRepresentation
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DashMuxingType Type { get; set; }
        
        /// <summary>
        /// Path to segments
        /// </summary>
        [JsonProperty(PropertyName = "segmentPath")]
        public string SegmentPath { get; set; }
        
        /// <summary>
        /// Number of the first segment
        /// </summary>
        [JsonProperty(PropertyName = "startSegmentNumber")]
        public long? StartSegmentNumber { get; set; }
        
        /// <summary>
        /// Number of the last segment. Default is the last one that was encoded
        /// </summary>
        [JsonProperty(PropertyName = "endSegmentNumber")]
        public long? EndSegmentNumber { get; set; }
        
        /// <summary>
        /// Id of the Keyframe to start with
        /// </summary>
        [JsonProperty(PropertyName = "startKeyframeId")]
        public string StartKeyframeId { get; set; }
        
        /// <summary>
        /// Id of the Keyframe to end with
        /// </summary>
        [JsonProperty(PropertyName = "endKeyframeId")]
        public string EndKeyframeId { get; set; }
    }

}
