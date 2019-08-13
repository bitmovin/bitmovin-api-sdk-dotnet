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
    /// AdAnalyticsQueryRequest
    /// </summary>

    public class AdAnalyticsQueryRequest : AnalyticsQueryTimeframe
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
        public List<AdAnalyticsAbstractFilter> Filters { get; set; } = new List<AdAnalyticsAbstractFilter>();
        
        /// <summary>
        /// OrderBy
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public List<AdAnalyticsOrderByEntry> OrderBy { get; set; } = new List<AdAnalyticsOrderByEntry>();
        
        /// <summary>
        /// Dimension
        /// </summary>
        [JsonProperty(PropertyName = "dimension")]
        public AdAnalyticsAttribute? Dimension { get; set; }
        
        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public AnalyticsInterval? Interval { get; set; }
        
        /// <summary>
        /// GroupBy
        /// </summary>
        [JsonProperty(PropertyName = "groupBy")]
        public List<AdAnalyticsAttribute> GroupBy { get; set; } = new List<AdAnalyticsAttribute>();
        
        /// <summary>
        /// Maximum number of rows returned (max. 200)
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; set; }
        
        /// <summary>
        /// Offset of data
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public long? Offset { get; set; }
    }

}
