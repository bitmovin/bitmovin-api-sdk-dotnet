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
        /// Timestamp when the task status changed to \&quot;RUNNING\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "runningAt")]
        public DateTime? RunningAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask status changed to a final state like &#39;FINISHED&#39;, &#39;ERROR&#39;, &#39;CANCELED&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ  Note that this timestamp might be inaccurate for tasks which ran prior to the [1.50.0 REST API release](https://bitmovin.com/docs/encoding/changelogs/rest). 
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask status changed to &#39;ERROR&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ  Note that this timestamp is deprecated and is equivalent to finishedAt in case of an &#39;ERROR&#39;. 
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
