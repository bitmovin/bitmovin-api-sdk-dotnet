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
    /// Subtask
    /// </summary>

    public class Subtask : BitmovinResponse
    {
        /// <summary>
        /// Current status (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; set; }
        
        /// <summary>
        /// Progress in percent
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; set; }
        
        /// <summary>
        /// Name of the subtask (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Task specific messages
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public List<Message> Messages { get; set; } = new List<Message>();
        
        /// <summary>
        /// Timestamp when the subtask was created, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        /// <summary>
        /// Timestamp when the subtask was last updated, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        /// <summary>
        /// Timestamp when the subtask was started, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public DateTime? StartedAt { get; set; }
        
        /// <summary>
        /// Timestamp when the subtask status changed to &#39;QUEUED&#39;, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "queuedAt")]
        public DateTime? QueuedAt { get; set; }
        
        /// <summary>
        /// Timestamp when the subtask status changed to to &#39;RUNNING&#39;, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "runningAt")]
        public DateTime? RunningAt { get; set; }
        
        /// <summary>
        /// Timestamp when the subtask status changed to &#39;FINISHED&#39;, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; set; }
        
        /// <summary>
        /// Timestamp when the subtask status changed to &#39;ERROR&#39;, formatted in UTC: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "errorAt")]
        public DateTime? ErrorAt { get; set; }
    }

}
