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
    /// LiveOptionsStatistics
    /// </summary>
    public class LiveOptionsStatistics
    {
        /// <summary>
        /// Summary
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public LiveOptionsSummary Summary { get; set; }

        /// <summary>
        /// Live options statistics aggregated per day (required)
        /// </summary>
        [JsonProperty(PropertyName = "breakdown")]
        public List<LiveOptionsBreakdownEntry> Breakdown { get; set; } = new List<LiveOptionsBreakdownEntry>();
    }
}
