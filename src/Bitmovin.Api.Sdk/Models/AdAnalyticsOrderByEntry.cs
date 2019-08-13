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
    /// AdAnalyticsOrderByEntry
    /// </summary>

    public class AdAnalyticsOrderByEntry
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public AdAnalyticsAttribute? Name { get; set; }
        
        /// <summary>
        /// Order
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public AnalyticsOrder? Order { get; set; }
    }

}
