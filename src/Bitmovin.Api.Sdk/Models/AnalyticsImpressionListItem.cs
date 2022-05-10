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
    /// AnalyticsImpressionListItem
    /// </summary>
    public class AnalyticsImpressionListItem
    {
        /// <summary>
        /// Random UUID that is used to identify a session (required)
        /// </summary>
        [JsonProperty(PropertyName = "impressionId")]
        public string ImpressionId { get; set; }
    }
}
