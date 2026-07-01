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
    /// Aggregate statistics of per-segment total processing duration over a rolling window of completed segments.
    /// </summary>
    public class LiveEncodingHeartbeatTotalProcessingStatsMs
    {
        /// <summary>
        /// Minimum total processing duration in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public long? Min { get; set; }

        /// <summary>
        /// Maximum total processing duration in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public long? Max { get; set; }

        /// <summary>
        /// Mean total processing duration in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "mean")]
        public long? Mean { get; set; }

        /// <summary>
        /// Median total processing duration in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "median")]
        public long? Median { get; set; }
    }
}
