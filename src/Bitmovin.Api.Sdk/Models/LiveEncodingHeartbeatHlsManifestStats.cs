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
    /// HLS manifest update monitoring data for a live encoding heartbeat.
    /// </summary>
    public class LiveEncodingHeartbeatHlsManifestStats
    {
        /// <summary>
        /// Id of the HLS manifest these statistics belong to.
        /// </summary>
        [JsonProperty(PropertyName = "manifestId")]
        public string ManifestId { get; set; }

        /// <summary>
        /// Aggregate latency statistics over recorded manifest updates.
        /// </summary>
        [JsonProperty(PropertyName = "manifestUpdateLatencyStats")]
        public LiveEncodingHeartbeatManifestUpdateLatencyStats ManifestUpdateLatencyStats { get; set; }

        /// <summary>
        /// Per-manifest outlier-only (high-latency) manifest updates, ordered newest to oldest.
        /// </summary>
        [JsonProperty(PropertyName = "manifestUpdates")]
        public List<LiveEncodingHeartbeatManifestUpdate> ManifestUpdates { get; set; } = new List<LiveEncodingHeartbeatManifestUpdate>();
    }
}
