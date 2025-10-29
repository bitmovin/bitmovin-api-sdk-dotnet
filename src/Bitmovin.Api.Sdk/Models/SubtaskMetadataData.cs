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
    /// SubtaskMetadataData
    /// </summary>
    public class SubtaskMetadataData
    {
        /// <summary>
        /// AvgFramesEncodedPerSecond
        /// </summary>
        [JsonProperty(PropertyName = "avgFramesEncodedPerSecond")]
        public double? AvgFramesEncodedPerSecond { get; set; }

        /// <summary>
        /// BytesEncoded
        /// </summary>
        [JsonProperty(PropertyName = "bytesEncoded")]
        public long? BytesEncoded { get; set; }

        /// <summary>
        /// FramesAnalysed
        /// </summary>
        [JsonProperty(PropertyName = "framesAnalysed")]
        public long? FramesAnalysed { get; set; }

        /// <summary>
        /// FramesEncoded
        /// </summary>
        [JsonProperty(PropertyName = "framesEncoded")]
        public long? FramesEncoded { get; set; }

        /// <summary>
        /// RealtimeFactor
        /// </summary>
        [JsonProperty(PropertyName = "realtimeFactor")]
        public double? RealtimeFactor { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
    }
}
