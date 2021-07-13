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
    /// AnalyticsAdsImpressionsResponse
    /// </summary>
    public class AnalyticsAdsImpressionsResponse
    {
        /// <summary>
        /// AdsImpressions
        /// </summary>
        [JsonProperty(PropertyName = "adsImpressions")]
        public List<AnalyticsAdsImpressionSample> AdsImpressions { get; set; } = new List<AnalyticsAdsImpressionSample>();
    }
}
