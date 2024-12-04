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
    /// LiveEncodingStatsEventDetails
    /// </summary>
    public class LiveEncodingStatsEventDetails
    {
        /// <summary>
        /// EventType
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public LiveEncodingEventName? EventType { get; set; }

        /// <summary>
        /// Short description of the event
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; internal set; }

        /// <summary>
        /// Name of the mid roll asset name
        /// </summary>
        [JsonProperty(PropertyName = "midRollAssetNames")]
        public List<string> MidRollAssetNames { get; internal set; } = new List<string>();

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty(PropertyName = "durationInSeconds")]
        public double? DurationInSeconds { get; internal set; }
    }
}
