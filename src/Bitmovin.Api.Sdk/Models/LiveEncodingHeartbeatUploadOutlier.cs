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
    /// A single per-muxing segment upload whose duration exceeded the upload-outlier threshold.
    /// </summary>
    public class LiveEncodingHeartbeatUploadOutlier
    {
        /// <summary>
        /// Output segment number this upload belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "segmentNumber")]
        public long? SegmentNumber { get; set; }

        /// <summary>
        /// Identifier of the muxing whose upload was flagged.
        /// </summary>
        [JsonProperty(PropertyName = "encodingReferenceMuxingId")]
        public string EncodingReferenceMuxingId { get; set; }

        /// <summary>
        /// Upload duration in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "durationMs")]
        public long? DurationMs { get; set; }
    }
}
