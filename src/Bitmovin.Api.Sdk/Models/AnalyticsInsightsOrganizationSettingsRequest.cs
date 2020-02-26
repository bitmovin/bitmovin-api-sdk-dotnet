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
    /// AnalyticsInsightsOrganizationSettingsRequest
    /// </summary>
    public class AnalyticsInsightsOrganizationSettingsRequest
    {
        /// <summary>
        /// Whether the organization&#39;s data is being contributed to industry insights
        /// </summary>
        [JsonProperty(PropertyName = "includeInInsights")]
        public bool? IncludeInInsights { get; set; }
    }
}
