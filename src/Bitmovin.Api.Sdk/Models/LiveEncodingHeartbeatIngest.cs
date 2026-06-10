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
    /// Information about the live ingestion status
    /// </summary>
    public class LiveEncodingHeartbeatIngest
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public LiveEncodingStatus? Status { get; set; }

        /// <summary>
        /// Indicates whether the ingest is healthy.
        /// </summary>
        [JsonProperty(PropertyName = "healthy")]
        public bool? Healthy { get; set; }

        /// <summary>
        /// Data about individual ingestPoints within the active live ingest. 
        /// </summary>
        [JsonProperty(PropertyName = "ingestPoints")]
        public List<LiveEncodingHeartbeatIngestPoint> IngestPoints { get; set; } = new List<LiveEncodingHeartbeatIngestPoint>();

        /// <summary>
        /// Data about individual streams within the active live ingest. 
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public List<LiveEncodingHeartbeatIngestStream> Streams { get; set; } = new List<LiveEncodingHeartbeatIngestStream>();

        /// <summary>
        /// RtmpUserIngestInfo
        /// </summary>
        [JsonProperty(PropertyName = "rtmpUserIngestInfo")]
        public RtmpUserIngestInfo RtmpUserIngestInfo { get; set; }

        /// <summary>
        /// Total number of dropped video packets since the live encoding started. 
        /// </summary>
        [JsonProperty(PropertyName = "droppedPacketsVideo")]
        public long? DroppedPacketsVideo { get; set; }

        /// <summary>
        /// Total number of dropped audio packets since the live encoding started. 
        /// </summary>
        [JsonProperty(PropertyName = "droppedPacketsAudio")]
        public long? DroppedPacketsAudio { get; set; }

        /// <summary>
        /// Total number of corrupt video packets since the live encoding started. 
        /// </summary>
        [JsonProperty(PropertyName = "corruptPacketsVideo")]
        public long? CorruptPacketsVideo { get; set; }

        /// <summary>
        /// Total number of corrupt audio packets since the live encoding started. 
        /// </summary>
        [JsonProperty(PropertyName = "corruptPacketsAudio")]
        public long? CorruptPacketsAudio { get; set; }
    }
}
