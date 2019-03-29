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
    /// NotificationStateEntry
    /// </summary>

    public class NotificationStateEntry : BitmovinResponse
    {
        /// <summary>
        /// State
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public NotificationStates State { get; set; }
        
        /// <summary>
        /// Indicate if notification was sent
        /// </summary>
        [JsonProperty(PropertyName = "muted")]
        public bool? Muted { get; set; }
        
        /// <summary>
        /// The notification this state belongs to
        /// </summary>
        [JsonProperty(PropertyName = "notificationId")]
        public string NotificationId { get; set; }
        
        /// <summary>
        /// Indicate if triggered for specific resource
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <summary>
        /// TriggeredAt
        /// </summary>
        [JsonProperty(PropertyName = "triggeredAt")]
        public DateTime? TriggeredAt { get; set; }
    }

}
