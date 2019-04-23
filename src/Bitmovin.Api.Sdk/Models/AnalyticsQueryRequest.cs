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
    /// AnalyticsQueryRequest
    /// </summary>

    public class AnalyticsQueryRequest : AnalyticsQueryTimeframe
    {
        /// <summary>
        /// Analytics license key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
        
        /// <summary>
        /// Filters
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<AnalyticsFilter> Filters { get; set; }
        
        /// <summary>
        /// OrderBy
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public List<AnalyticsOrderByEntry> OrderBy { get; set; }
        
        /// <summary>
        /// Dimension
        /// </summary>
        [JsonProperty(PropertyName = "dimension")]
        public string Dimension { get; set; }
        
        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public AnalyticsInterval Interval { get; set; }
        
        /// <summary>
        /// GroupBy
        /// </summary>
        [JsonProperty(PropertyName = "groupBy")]
        public List<string> GroupBy { get; set; }
        
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
