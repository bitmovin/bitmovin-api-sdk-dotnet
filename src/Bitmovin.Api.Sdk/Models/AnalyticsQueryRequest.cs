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
        /// Analytics license key (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Analytics Query Filters  Each filter requires 3 properties: name, operator and value.   Valid operators are [IN, EQ, NE, LT, LTE, GT, GTE, CONTAINS, NOTCONTAINS] 
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<AnalyticsAbstractFilter> Filters { get; set; } = new List<AnalyticsAbstractFilter>();

        /// <summary>
        /// OrderBy
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public List<AnalyticsOrderByEntry> OrderBy { get; set; } = new List<AnalyticsOrderByEntry>();

        /// <summary>
        /// Dimension
        /// </summary>
        [JsonProperty(PropertyName = "dimension")]
        public AnalyticsAttribute? Dimension { get; set; }

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
        /// Whether context data should be included in the response
        /// </summary>
        [JsonProperty(PropertyName = "includeContext")]
        public bool? IncludeContext { get; set; }

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
