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
    /// SrtStatistics
    /// </summary>
    public class SrtStatistics
    {
        /// <summary>
        /// UUID of the statistic event
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Timestamp when the srt statistics event was created, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UUID of an encoding
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// UUID of the SRT input used to capture this statistics
        /// </summary>
        [JsonProperty(PropertyName = "srtInputId")]
        public string SrtInputId { get; set; }

        /// <summary>
        /// Whether the SRT input that generated this statistics was selected (i.e. actively used) at the time or not
        /// </summary>
        [JsonProperty(PropertyName = "srtInputSelected")]
        public bool? SrtInputSelected { get; set; }

        /// <summary>
        /// UUID of the associated organization
        /// </summary>
        [JsonProperty(PropertyName = "orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// UUID of the associated api-user
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public SrtStatisticLink Link { get; set; }

        /// <summary>
        /// Window
        /// </summary>
        [JsonProperty(PropertyName = "window")]
        public SrtStatisticWindow Window { get; set; }

        /// <summary>
        /// Recv
        /// </summary>
        [JsonProperty(PropertyName = "recv")]
        public SrtStatisticRecv Recv { get; set; }

        /// <summary>
        /// Send
        /// </summary>
        [JsonProperty(PropertyName = "send")]
        public SrtStatisticSend Send { get; set; }
    }
}
