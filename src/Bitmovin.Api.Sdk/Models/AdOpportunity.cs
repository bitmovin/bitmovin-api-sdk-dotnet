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
    /// AdOpportunity
    /// </summary>
    public class AdOpportunity
    {
        /// <summary>
        /// Explanation of the scene boundary&#39;s suitability for an ad break, including low or zero suitability.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Suitability of placing an ad break at the end of the scene. Higher scores indicate greater suitability. A score of 0.5 can also mean that no assessment is available.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }
    }
}
