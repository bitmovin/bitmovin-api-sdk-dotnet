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
        /// Source used for clock-synchronization
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public ClockSynchronizationMode? Source { get; internal set; }

        /// <summary>
        /// Year specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "year")]
        public long? Year { get; internal set; }

        /// <summary>
        /// Month specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "month")]
        public long? Month { get; internal set; }

        /// <summary>
        /// Day specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public long? Day { get; internal set; }

        /// <summary>
        /// Hours specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "hours")]
        public long? Hours { get; internal set; }

        /// <summary>
        /// Minutes specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "minutes")]
        public long? Minutes { get; internal set; }

        /// <summary>
        /// Seconds specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "seconds")]
        public long? Seconds { get; internal set; }

        /// <summary>
        /// Microseconds specified in picture timing
        /// </summary>
        [JsonProperty(PropertyName = "microSeconds")]
        public long? MicroSeconds { get; internal set; }
    }
}
