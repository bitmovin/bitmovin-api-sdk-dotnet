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
    /// ObjectDetectionTimestampResult
    /// </summary>

    public class ObjectDetectionTimestampResult : BitmovinResponse
    {
        /// <summary>
        /// Time in seconds where the object was detected in the video
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public double? Timestamp { get; set; }
        
        /// <summary>
        /// Objects detected for the given timestamp
        /// </summary>
        [JsonProperty(PropertyName = "objects")]
        public List<ObjectDetectionResult> Objects { get; set; } = new List<ObjectDetectionResult>();
    }

}
