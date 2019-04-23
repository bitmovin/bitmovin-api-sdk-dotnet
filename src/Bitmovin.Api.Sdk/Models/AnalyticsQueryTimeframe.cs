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
    /// AnalyticsQueryTimeframe
    /// </summary>

    public class AnalyticsQueryTimeframe
    {
        /// <summary>
        /// Start of timeframe which is queried
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }
        
        /// <summary>
        /// End of timeframe which is queried
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }
    }

}
