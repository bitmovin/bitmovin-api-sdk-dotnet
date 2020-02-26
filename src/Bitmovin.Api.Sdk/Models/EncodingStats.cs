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
    /// EncodingStats
    /// </summary>
    public class EncodingStats
    {
        /// <summary>
        /// Date, format. yyyy-MM-dd
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; internal set; }

        /// <summary>
        /// The id of the encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// Total bytes encoded
        /// </summary>
        [JsonProperty(PropertyName = "bytesEncoded")]
        public long? BytesEncoded { get; internal set; }

        /// <summary>
        /// Total time encoded
        /// </summary>
        [JsonProperty(PropertyName = "timeEncoded")]
        public long? TimeEncoded { get; internal set; }

        /// <summary>
        /// Downloaded size of the input file
        /// </summary>
        [JsonProperty(PropertyName = "downloadedSize")]
        public long? DownloadedSize { get; internal set; }

        /// <summary>
        /// Billable minutes
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; internal set; }

        /// <summary>
        /// Billable egress output
        /// </summary>
        [JsonProperty(PropertyName = "billableEgressBytes")]
        public List<EgressInformation> BillableEgressBytes { get; internal set; } = new List<EgressInformation>();

        /// <summary>
        /// Detailed statistics per stream
        /// </summary>
        [JsonProperty(PropertyName = "billableEncodingMinutes")]
        public List<BillableEncodingMinutes> BillableEncodingMinutes { get; internal set; } = new List<BillableEncodingMinutes>();

        /// <summary>
        /// Billable transmuxing minutes (required)
        /// </summary>
        [JsonProperty(PropertyName = "billableTransmuxingMinutes")]
        public double? BillableTransmuxingMinutes { get; internal set; }

        /// <summary>
        /// Billable feature minutes
        /// </summary>
        [JsonProperty(PropertyName = "billableFeatureMinutes")]
        public double? BillableFeatureMinutes { get; internal set; }

        /// <summary>
        /// Detailed statistics per stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public List<StatisticsPerStream> Streams { get; internal set; } = new List<StatisticsPerStream>();

        /// <summary>
        /// Detailed statistics per muxing (required)
        /// </summary>
        [JsonProperty(PropertyName = "muxings")]
        public List<StatisticsPerMuxing> Muxings { get; internal set; } = new List<StatisticsPerMuxing>();

        /// <summary>
        /// Detailed statistics per feature
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public List<BillableEncodingFeatureMinutes> Features { get; internal set; } = new List<BillableEncodingFeatureMinutes>();
    }
}
