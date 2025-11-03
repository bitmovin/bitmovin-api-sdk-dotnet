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
    /// AnalyticsErrorDetail
    /// </summary>
    public class AnalyticsErrorDetail
    {
        /// <summary>
        /// Error id
        /// </summary>
        [JsonProperty(PropertyName = "errorId")]
        public long? ErrorId { get; set; }

        /// <summary>
        /// Server timestamp
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Client timestamp
        /// </summary>
        [JsonProperty(PropertyName = "clientTime")]
        public DateTime? ClientTime { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// ErrorData
        /// </summary>
        [JsonProperty(PropertyName = "errorData")]
        public AnalyticsErrorData ErrorData { get; set; }

        /// <summary>
        /// Severity of the error
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// HttpRequests
        /// </summary>
        [JsonProperty(PropertyName = "httpRequests")]
        public List<AnalyticsHttpRequest> HttpRequests { get; set; } = new List<AnalyticsHttpRequest>();
    }
}
