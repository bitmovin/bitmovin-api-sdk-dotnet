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
    /// CustomTag
    /// </summary>

    public class CustomTag : BitmovinResource
    {
        /// <summary>
        /// The positioning mode that should be used when inserting the placement opportunity
        /// </summary>
        [JsonProperty(PropertyName = "positionMode")]
        public PositionMode PositionMode { get; set; }
        
        /// <summary>
        /// Id of keyframe where the custom tag should be inserted. Required, when KEYFRAME is selected as position mode.
        /// </summary>
        [JsonProperty(PropertyName = "keyframeId")]
        public string KeyframeId { get; set; }
        
        /// <summary>
        /// Time in seconds where the custom tag should be inserted. Required, when TIME is selected as position mode.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }
        
        /// <summary>
        /// The custom tag will be inserted before the specified segment. Required, when SEGMENT is selected as position mode.
        /// </summary>
        [JsonProperty(PropertyName = "segment")]
        public long? Segment { get; set; }
        
        /// <summary>
        /// The data to be contained in the custom tag.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
    }

}
