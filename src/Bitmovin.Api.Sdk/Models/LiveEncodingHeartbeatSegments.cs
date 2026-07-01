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
    /// Segment processing statistics for a live encoding heartbeat.
    /// </summary>
    public class LiveEncodingHeartbeatSegments
    {
        /// <summary>
        /// Aggregate statistics of per-segment total processing duration.
        /// </summary>
        [JsonProperty(PropertyName = "totalProcessingStatsMs")]
        public LiveEncodingHeartbeatTotalProcessingStatsMs TotalProcessingStatsMs { get; set; }

        /// <summary>
        /// Last 20 per-muxing uploads whose duration exceeded the upload-outlier threshold.
        /// </summary>
        [JsonProperty(PropertyName = "uploadOutliers")]
        public List<LiveEncodingHeartbeatUploadOutlier> UploadOutliers { get; set; } = new List<LiveEncodingHeartbeatUploadOutlier>();

        /// <summary>
        /// Last 20 segments whose total processing duration exceeded twice the rolling median.
        /// </summary>
        [JsonProperty(PropertyName = "totalProcessingOutliers")]
        public List<LiveEncodingHeartbeatTotalProcessingOutlier> TotalProcessingOutliers { get; set; } = new List<LiveEncodingHeartbeatTotalProcessingOutlier>();
    }
}
