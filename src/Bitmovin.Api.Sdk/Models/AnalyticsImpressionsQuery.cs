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
        /// Analytics license key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
        
        /// <summary>
        /// Filters
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<AnalyticsAbstractFilter> Filters { get; set; } = new List<AnalyticsAbstractFilter>();
    }

}
