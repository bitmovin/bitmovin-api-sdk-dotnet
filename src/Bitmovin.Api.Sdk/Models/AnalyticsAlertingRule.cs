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
    /// AnalyticsAlertingRule
    /// </summary>
    public class AnalyticsAlertingRule
    {
        /// <summary>
        /// The id of the alerting rule
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// License key of the alerting rule
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; internal set; }

        /// <summary>
        /// Type of alerting rule
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; internal set; }

        /// <summary>
        /// Alerting rule name (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Metric
        /// </summary>
        [JsonProperty(PropertyName = "metric")]
        public AnalyticsRuleMetric? Metric { get; set; }

        /// <summary>
        /// Filters
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<AnalyticsAbstractFilter> Filters { get; set; } = new List<AnalyticsAbstractFilter>();

        /// <summary>
        /// Options
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public AnalyticsThresholdRuleOptions Options { get; set; }

        /// <summary>
        /// Notification
        /// </summary>
        [JsonProperty(PropertyName = "notification")]
        public AnalyticsAlertingNotification Notification { get; set; }
    }
}
