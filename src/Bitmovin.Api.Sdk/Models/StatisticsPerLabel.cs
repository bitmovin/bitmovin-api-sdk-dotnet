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
    /// StatisticsPerLabel
    /// </summary>

    public class StatisticsPerLabel : Statistics
    {
        /// <summary>
        /// An optional error message, when the event is in error state (occurs at event: ERROR) (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <summary>
        /// The billable minutes.
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; set; }
        
        /// <summary>
        /// Billable minutes for each encoding configuration
        /// </summary>
        [JsonProperty(PropertyName = "billableEncodingMinutes")]
        public List<BillableEncodingMinutes> BillableEncodingMinutes { get; internal set; } = new List<BillableEncodingMinutes>();
        
        /// <summary>
        /// Billable minutes for muxings.
        /// </summary>
        [JsonProperty(PropertyName = "billableTransmuxingMinutes")]
        public double? BillableTransmuxingMinutes { get; set; }
        
        /// <summary>
        /// Billable minutes for features
        /// </summary>
        [JsonProperty(PropertyName = "billableFeatureMinutes")]
        public List<BillableEncodingFeatureMinutes> BillableFeatureMinutes { get; internal set; } = new List<BillableEncodingFeatureMinutes>();
    }

}
