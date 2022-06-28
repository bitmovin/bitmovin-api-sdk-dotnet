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
    /// AnalyticsImpressionsQuery
    /// </summary>
    public class AnalyticsImpressionsQuery : AnalyticsQueryTimeframe
    {
        /// <summary>
        /// Analytics license key (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Analytics Query Filters  Each filter requires 3 properties: name, operator and value.  Valid operators are [IN, EQ, NE, LT, LTE, GT, GTE, CONTAINS, NOTCONTAINS] 
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<AnalyticsAbstractFilter> Filters { get; set; } = new List<AnalyticsAbstractFilter>();

        /// <summary>
        /// Number of returned impressions
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
    }
}
