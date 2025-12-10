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
    /// LiveEncodingHeartbeatEventDetails
    /// </summary>
    public class LiveEncodingHeartbeatEventDetails
    {
        /// <summary>
        /// EventType
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public LiveEncodingHeartbeatEventType? EventType { get; set; }

        /// <summary>
        /// Short description of the event
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
