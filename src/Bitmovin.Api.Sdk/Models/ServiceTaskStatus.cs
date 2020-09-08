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
    /// ServiceTaskStatus
    /// </summary>
    public class ServiceTaskStatus : BitmovinResponse
    {
        /// <summary>
        /// Current status (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; set; }

        /// <summary>
        /// Estimated ETA in seconds
        /// </summary>
        [JsonProperty(PropertyName = "eta")]
        public double? Eta { get; set; }

        /// <summary>
        /// Progress in percent
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// List of subtasks
        /// </summary>
        [JsonProperty(PropertyName = "subtasks")]
        public List<Subtask> Subtasks { get; set; } = new List<Subtask>();

        /// <summary>
        /// Task specific messages
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public List<Message> Messages { get; set; } = new List<Message>();

        /// <summary>
        /// Timestamp when the task was created, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the task status changed to \&quot;QUEUED\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "queuedAt")]
        public DateTime? QueuedAt { get; set; }

        /// <summary>
        /// Timestamp when the task status changed to to \&quot;RUNNING\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "runningAt")]
        public DateTime? RunningAt { get; set; }

        /// <summary>
        /// Timestamp when the task status changed to \&quot;FINISHED\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Timestamp when the task status changed to \&quot;ERROR\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "errorAt")]
        public DateTime? ErrorAt { get; set; }

        /// <summary>
        /// Additional optional error details
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorDetails Error { get; set; }
    }
}
