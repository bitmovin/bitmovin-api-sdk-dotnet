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
    /// TransferRetry
    /// </summary>
    public class TransferRetry : BitmovinResource
    {
        /// <summary>
        /// The current status of the transfer-retry.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; internal set; }

        /// <summary>
        /// Timestamp when the transfer-retry was started, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// Timestamp when the transfer-retry status changed to &#39;FINISHED&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// Timestamp when the transfer-retry status changed to &#39;ERROR&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty(PropertyName = "errorAt")]
        public DateTime? ErrorAt { get; internal set; }
    }
}
