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
    /// AnalyticsMetricsQueryRequest
    /// </summary>

    public class AnalyticsMetricsQueryRequest : AnalyticsQueryTimeframe
    {
        /// <summary>
        /// Analytics license key (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
        
        /// <summary>
        /// Filters
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<AnalyticsAbstractFilter> Filters { get; set; } = new List<AnalyticsAbstractFilter>();
        
        /// <summary>
        /// OrderBy
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public List<AnalyticsOrderByEntry> OrderBy { get; set; } = new List<AnalyticsOrderByEntry>();
        
        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public AnalyticsInterval? Interval { get; set; }
        
        /// <summary>
        /// GroupBy
        /// </summary>
        [JsonProperty(PropertyName = "groupBy")]
        public List<AnalyticsAttribute> GroupBy { get; set; } = new List<AnalyticsAttribute>();
        
        /// <summary>
        /// Maximum number of rows returned (max. 200)
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; set; }
        
        /// <summary>
        /// Offset of data used for pagination
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public long? Offset { get; set; }
    }

}
