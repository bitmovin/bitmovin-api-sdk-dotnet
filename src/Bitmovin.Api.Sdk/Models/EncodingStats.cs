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
        public DateTime? Date { get; set; }
        
        /// <summary>
        /// The id of the encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }
        
        /// <summary>
        /// Total bytes encoded
        /// </summary>
        [JsonProperty(PropertyName = "bytesEncoded")]
        public long? BytesEncoded { get; set; }
        
        /// <summary>
        /// Total time encoded
        /// </summary>
        [JsonProperty(PropertyName = "timeEncoded")]
        public long? TimeEncoded { get; set; }
        
        /// <summary>
        /// Downloaded size of the input file
        /// </summary>
        [JsonProperty(PropertyName = "downloadedSize")]
        public long? DownloadedSize { get; set; }
        
        /// <summary>
        /// Billable minutes
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; set; }
        
        /// <summary>
        /// Detailed statistics per stream
        /// </summary>
        [JsonProperty(PropertyName = "billableEncodingMinutes")]
        public List<BillableEncodingMinutes> BillableEncodingMinutes { get; set; } = new List<BillableEncodingMinutes>();
        
        /// <summary>
        /// Billable transmuxing minutes (required)
        /// </summary>
        [JsonProperty(PropertyName = "billableTransmuxingMinutes")]
        public double? BillableTransmuxingMinutes { get; set; }
        
        /// <summary>
        /// Billable feature minutes
        /// </summary>
        [JsonProperty(PropertyName = "billableFeatureMinutes")]
        public double? BillableFeatureMinutes { get; set; }
        
        /// <summary>
        /// Detailed statistics per stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public List<StatisticsPerStream> Streams { get; set; } = new List<StatisticsPerStream>();
        
        /// <summary>
        /// Detailed statistics per muxing (required)
        /// </summary>
        [JsonProperty(PropertyName = "muxings")]
        public List<StatisticsPerMuxing> Muxings { get; set; } = new List<StatisticsPerMuxing>();
        
        /// <summary>
        /// Detailed statistics per feature
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public List<BillableEncodingFeatureMinutes> Features { get; set; } = new List<BillableEncodingFeatureMinutes>();
    }

}
