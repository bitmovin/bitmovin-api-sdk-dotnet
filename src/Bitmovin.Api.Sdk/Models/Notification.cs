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
    /// Notification
    /// </summary>
    public class Notification : BitmovinResponse
    {
        /// <summary>
        /// Notify when condition resolves after it was met
        /// </summary>
        [JsonProperty(PropertyName = "resolve")]
        public bool? Resolve { get; set; }

        /// <summary>
        /// Specific resource, e.g. encoding id
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Last time the notification was triggered
        /// </summary>
        [JsonProperty(PropertyName = "triggeredAt")]
        public DateTime? TriggeredAt { get; internal set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// EventType
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// ResourceType
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Muted
        /// </summary>
        [JsonProperty(PropertyName = "muted")]
        public bool? Muted { get; set; }

        /// <summary>
        /// User-specific meta data. This can hold anything.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public Dictionary<string, Object> CustomData { get; set; } = new Dictionary<string, Object>();
    }
}
