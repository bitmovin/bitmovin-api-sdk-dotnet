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
        /// Task specific metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public List<SubtaskMetadata> Metadata { get; set; } = new List<SubtaskMetadata>();

        /// <summary>
        /// Timestamp when the subtask was created, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask was last updated, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask was started, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask status changed to &#39;QUEUED&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "queuedAt")]
        public DateTime? QueuedAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask status changed to &#39;RUNNING&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "runningAt")]
        public DateTime? RunningAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask status changed to a final state like  &#39;FINISHED&#39;, &#39;ERROR&#39;, &#39;CANCELED&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ  Note that this timestamp might be inaccurate for subtasks which ran prior to the [1.50.0 REST API release](https://bitmovin.com/docs/encoding/changelogs/rest). 
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Timestamp when the subtask status changed to &#39;ERROR&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ  Note that this timestamp is deprecated and is equivalent to finishedAt in case of an &#39;ERROR&#39;. 
        /// </summary>
        [JsonProperty(PropertyName = "errorAt")]
        public DateTime? ErrorAt { get; set; }
    }
}
