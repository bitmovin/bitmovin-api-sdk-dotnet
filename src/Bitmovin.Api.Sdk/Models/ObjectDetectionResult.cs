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
    /// ObjectDetectionResult
    /// </summary>
    public class ObjectDetectionResult : BitmovinResponse
    {
        /// <summary>
        /// Name of the object that has been detected (in English)
        /// </summary>
        [JsonProperty(PropertyName = "detectedObject")]
        public string DetectedObject { get; set; }

        /// <summary>
        /// Time in seconds where the object was detected in the video
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// A number between 0 and 1 indicating the confidence of the detection
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// A box indicating the position and size of the detected object within the frame
        /// </summary>
        [JsonProperty(PropertyName = "boundingBox")]
        public ObjectDetectionBoundingBox BoundingBox { get; set; }
    }
}
