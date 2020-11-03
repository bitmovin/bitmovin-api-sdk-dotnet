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
    /// AnalyticsThresholdRuleOptions
    /// </summary>
    public class AnalyticsThresholdRuleOptions
    {
        /// <summary>
        /// Threshold for triggering alert (required)
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Persistence of threshold violation in minutes (required)
        /// </summary>
        [JsonProperty(PropertyName = "persistence")]
        public int? Persistence { get; set; }

        /// <summary>
        /// Sample size for rule processing (required)
        /// </summary>
        [JsonProperty(PropertyName = "sampleSize")]
        public int? SampleSize { get; set; }

        /// <summary>
        /// Number of minutes without violation after which incident is considered as recovered (required)
        /// </summary>
        [JsonProperty(PropertyName = "recovery")]
        public int? Recovery { get; set; }

        /// <summary>
        /// Interval for repeating notifications (required)
        /// </summary>
        [JsonProperty(PropertyName = "repeatInterval")]
        public int? RepeatInterval { get; set; }

        /// <summary>
        /// Send notification after incident is resolved
        /// </summary>
        [JsonProperty(PropertyName = "notifyOnResolved")]
        public bool? NotifyOnResolved { get; set; }
    }
}
