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
    /// DailyStatisticsPerLabel
    /// </summary>

    public class DailyStatisticsPerLabel
    {
        /// <summary>
        /// Date, format. yyyy-MM-dd (required)
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }
        
        /// <summary>
        /// List of labels and their aggregated statistics (required)
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public List<DailyStatistics> Labels { get; set; } = new List<DailyStatistics>();
    }

}
