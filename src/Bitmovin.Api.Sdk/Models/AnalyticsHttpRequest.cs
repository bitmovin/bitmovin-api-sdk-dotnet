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
    /// AnalyticsHttpRequest
    /// </summary>
    public class AnalyticsHttpRequest
    {
        /// <summary>
        /// Client timestamp
        /// </summary>
        [JsonProperty(PropertyName = "clientTime")]
        public DateTime? ClientTime { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AnalyticsHttpRequestType? Type { get; set; }

        /// <summary>
        /// Http request URL
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Last redirect location
        /// </summary>
        [JsonProperty(PropertyName = "lastRedirectLocation")]
        public string LastRedirectLocation { get; set; }

        /// <summary>
        /// Http request status
        /// </summary>
        [JsonProperty(PropertyName = "httpStatus")]
        public int? HttpStatus { get; set; }

        /// <summary>
        /// Download time
        /// </summary>
        [JsonProperty(PropertyName = "downloadTime")]
        public long? DownloadTime { get; set; }

        /// <summary>
        /// Time to first byte
        /// </summary>
        [JsonProperty(PropertyName = "timeToFirstByte")]
        public long? TimeToFirstByte { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }

        /// <summary>
        /// Was http request successful
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }
    }
}
