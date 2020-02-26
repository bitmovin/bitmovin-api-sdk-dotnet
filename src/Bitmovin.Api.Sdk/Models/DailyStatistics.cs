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
    /// DailyStatistics
    /// </summary>
    public class DailyStatistics
    {
        /// <summary>
        /// Date for the shown data. Format: yyyy-MM-dd (required)
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Bytes encoded. (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesEncoded")]
        public long? BytesEncoded { get; set; }

        /// <summary>
        /// Time in seconds encoded for this day. (required)
        /// </summary>
        [JsonProperty(PropertyName = "timeEncoded")]
        public long? TimeEncoded { get; set; }

        /// <summary>
        /// The billable minutes.
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; set; }

        /// <summary>
        /// Label identifier.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Billable minutes for each encoding configuration.
        /// </summary>
        [JsonProperty(PropertyName = "billableEncodingMinutes")]
        public List<BillableEncodingMinutes> BillableEncodingMinutes { get; internal set; } = new List<BillableEncodingMinutes>();

        /// <summary>
        /// Billable minutes for muxings.
        /// </summary>
        [JsonProperty(PropertyName = "billableTransmuxingMinutes")]
        public double? BillableTransmuxingMinutes { get; set; }

        /// <summary>
        /// Billable minutes for features
        /// </summary>
        [JsonProperty(PropertyName = "billableFeatureMinutes")]
        public List<BillableEncodingFeatureMinutes> BillableFeatureMinutes { get; internal set; } = new List<BillableEncodingFeatureMinutes>();

        /// <summary>
        /// BillableEgressBytes
        /// </summary>
        [JsonProperty(PropertyName = "billableEgressBytes")]
        public List<EgressInformation> BillableEgressBytes { get; internal set; } = new List<EgressInformation>();
    }
}
