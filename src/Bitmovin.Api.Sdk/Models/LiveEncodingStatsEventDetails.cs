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
        /// EventName
        /// </summary>
        [JsonProperty(PropertyName = "eventName")]
        public LiveEncodingEventName? EventName { get; set; }

        /// <summary>
        /// The Audio/Video Drift in seconds. The drift was corrected by the RESYNCING event (occurs at event: RESYNCING)
        /// </summary>
        [JsonProperty(PropertyName = "avDriftInSeconds")]
        public int? AvDriftInSeconds { get; set; }

        /// <summary>
        /// The time the stream was in idle state in seconds (occurs at event: IDLE)
        /// </summary>
        [JsonProperty(PropertyName = "idleDurationInSeconds")]
        public int? IdleDurationInSeconds { get; set; }

        /// <summary>
        /// An optional error message, when the event is in error state (occurs at event: ERROR)
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
