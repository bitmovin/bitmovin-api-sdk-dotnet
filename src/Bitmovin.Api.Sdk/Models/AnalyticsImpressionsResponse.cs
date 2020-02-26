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
    /// AnalyticsImpressionsResponse
    /// </summary>
    public class AnalyticsImpressionsResponse
    {
        /// <summary>
        /// Impressions
        /// </summary>
        [JsonProperty(PropertyName = "impressions")]
        public List<AnalyticsImpressionListItem> Impressions { get; set; } = new List<AnalyticsImpressionListItem>();
    }
}
