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
    /// LiveHlsManifest
    /// </summary>
    public class LiveHlsManifest
    {
        /// <summary>
        /// HLS manifest id (required)
        /// </summary>
        [JsonProperty(PropertyName = "manifestId")]
        public string ManifestId { get; set; }

        /// <summary>
        /// Timeshift in seconds. We recommend to use a timeshift value not greater than 3 hours (10800.0 seconds). Longer values could negatively impact the manifest update frequency. 
        /// </summary>
        [JsonProperty(PropertyName = "timeshift")]
        public double? Timeshift { get; set; }

        /// <summary>
        /// Live edge offset in seconds. New segments are held back for this duration (rounded up to whole segments) before they are added to the HLS playlist, and are always added in order. This adds the same amount of latency, but a segment that arrives late by up to this duration does not interrupt the playlist. A segment that arrives later than that stops the playlist from updating until it arrives. If it does not arrive at all, a placeholder segment is added in its place once a few newer segments are available. If set to 0, segments are added as soon as they are available. A late segment is then skipped and inserted into the playlist later, which can make players skip or repeat content. We recommend a value of at least 2 segment durations. 
        /// </summary>
        [JsonProperty(PropertyName = "liveEdgeOffset")]
        public double? LiveEdgeOffset { get; set; }

        /// <summary>
        /// Specifies if the EXT-X-PROGRAM-DATETIME tag will be included
        /// </summary>
        [JsonProperty(PropertyName = "insertProgramDateTime")]
        public bool? InsertProgramDateTime { get; set; }

        /// <summary>
        /// Configuration for the EXT-X-PROGRAM-DATETIME tag
        /// </summary>
        [JsonProperty(PropertyName = "programDateTimeSettings")]
        public ProgramDateTimeSettings ProgramDateTimeSettings { get; set; }

        /// <summary>
        /// Configuration for tags related to ad markers (e.g. Scte35)
        /// </summary>
        [JsonProperty(PropertyName = "adMarkerSettings")]
        public HlsManifestAdMarkerSettings AdMarkerSettings { get; set; }
    }
}
