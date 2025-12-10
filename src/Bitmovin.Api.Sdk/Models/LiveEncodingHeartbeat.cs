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
    /// Heartbeat data for a Live Encoding.
    /// </summary>
    public class LiveEncodingHeartbeat
    {
        /// <summary>
        /// timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Information about the live ingestion status 
        /// </summary>
        [JsonProperty(PropertyName = "ingest")]
        public LiveEncodingHeartbeatIngest Ingest { get; set; }

        /// <summary>
        /// Live encoding heartbeat events 
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public List<LiveEncodingHeartbeatEvent> Events { get; set; } = new List<LiveEncodingHeartbeatEvent>();
    }
}
