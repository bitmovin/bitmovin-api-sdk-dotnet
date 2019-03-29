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
        /// Time in seconds where the keyframe should be inserted
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }
        
        /// <summary>
        /// Instructs the encoder to cut the segment at this position
        /// </summary>
        [JsonProperty(PropertyName = "segmentCut")]
        public bool? SegmentCut { get; set; }
    }

}
