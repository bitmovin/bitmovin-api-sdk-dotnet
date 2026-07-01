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
    /// A single media-advancing HLS manifest update.
    /// </summary>
    public class LiveEncodingHeartbeatManifestUpdate
    {
        /// <summary>
        /// Wall-clock time the media-advancing manifest update occured, returned as UTC in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "manifestUpdateWallClockTime")]
        public DateTime? ManifestUpdateWallClockTime { get; set; }

        /// <summary>
        /// Latest media presentation time across renditions (min of all playlists&#39; stream progress), returned as UTC in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "latestMediaPresentationTime")]
        public DateTime? LatestMediaPresentationTime { get; set; }

        /// <summary>
        /// Manifest update latency in milliseconds (elapsed wall-clock minus media-time advanced).
        /// </summary>
        [JsonProperty(PropertyName = "manifestUpdateLatency")]
        public long? ManifestUpdateLatency { get; set; }
    }
}
