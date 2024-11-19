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
    /// LiveStandbyPoolEventLog
    /// </summary>
    public class LiveStandbyPoolEventLog
    {
        /// <summary>
        /// UUID of the entry
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Id of the standby_pool associated with the event log
        /// </summary>
        [JsonProperty(PropertyName = "standbyPoolId")]
        public string StandbyPoolId { get; internal set; }

        /// <summary>
        /// (Optional) Id of the standby pool encoding associated with the event
        /// </summary>
        [JsonProperty(PropertyName = "standbyPoolEncodingId")]
        public string StandbyPoolEncodingId { get; internal set; }

        /// <summary>
        /// Creation timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; internal set; }

        /// <summary>
        /// Short description of the event
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; internal set; }

        /// <summary>
        /// Detailed description, payloads, hints on how to resolve errors, etc
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; internal set; }

        /// <summary>
        /// EventType
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public LiveStandbyPoolEventLogType? EventType { get; set; }
    }
}
