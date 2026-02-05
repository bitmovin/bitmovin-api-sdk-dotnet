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
        /// The reason why the scene was rated with a certain score
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Score from 0.0 to 1.0 rating the ad placement suitability at the end of a scene based on content analysis
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public decimal? Score { get; set; }
    }
}
