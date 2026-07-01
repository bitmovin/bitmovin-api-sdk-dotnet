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
    /// Aggregate statistics of HLS manifest update latencies.
    /// </summary>
    public class LiveEncodingHeartbeatManifestUpdateLatencyStats
    {
        /// <summary>
        /// Mean manifest update latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "mean")]
        public long? Mean { get; set; }

        /// <summary>
        /// Median manifest update latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "median")]
        public long? Median { get; set; }

        /// <summary>
        /// Minimum manifest update latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public long? Min { get; set; }

        /// <summary>
        /// Maximum manifest update latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public long? Max { get; set; }
    }
}
