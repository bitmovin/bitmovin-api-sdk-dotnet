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
    /// AdAnalyticsPercentileQueryRequest
    /// </summary>

    public class AdAnalyticsPercentileQueryRequest : AnalyticsQueryRequest
    {
        /// <summary>
        /// The percentage (0-99) used for percentile queries.
        /// </summary>
        [JsonProperty(PropertyName = "percentile")]
        public long? Percentile { get; set; }
    }

}
