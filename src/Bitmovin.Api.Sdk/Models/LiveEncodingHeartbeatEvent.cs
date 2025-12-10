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
    /// LiveEncodingHeartbeatEvent
    /// </summary>
    public class LiveEncodingHeartbeatEvent
    {
        /// <summary>
        /// Timestamp of the event, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ (required)
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public LiveEncodingHeartbeatEventDetails Details { get; set; }
    }
}
