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
    /// A single segment whose total processing duration exceeded twice the rolling median.
    /// </summary>
    public class LiveEncodingHeartbeatTotalProcessingOutlier
    {
        /// <summary>
        /// Output segment number this measurement belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "segmentNumber")]
        public long? SegmentNumber { get; set; }

        /// <summary>
        /// Total processing duration in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "durationMs")]
        public long? DurationMs { get; set; }
    }
}
