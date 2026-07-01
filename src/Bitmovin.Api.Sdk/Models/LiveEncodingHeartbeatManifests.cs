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
    /// Manifest statistics for a live encoding heartbeat.
    /// </summary>
    public class LiveEncodingHeartbeatManifests
    {
        /// <summary>
        /// Per-manifest HLS update statistics; one entry per HLS manifest.
        /// </summary>
        [JsonProperty(PropertyName = "hls")]
        public List<LiveEncodingHeartbeatHlsManifestStats> Hls { get; set; } = new List<LiveEncodingHeartbeatHlsManifestStats>();
    }
}
