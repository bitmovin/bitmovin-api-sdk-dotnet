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
    /// AnalyticsInsightsOrganizationSettings
    /// </summary>

    public class AnalyticsInsightsOrganizationSettings
    {
        /// <summary>
        /// Organization ID
        /// </summary>
        [JsonProperty(PropertyName = "orgId")]
        public string OrgId { get; set; }
        
        /// <summary>
        /// Whether the organization&#39;s data is included in the industry insights
        /// </summary>
        [JsonProperty(PropertyName = "includeInInsights")]
        public bool? IncludeInInsights { get; set; }
        
        /// <summary>
        /// Industry of the organization
        /// </summary>
        [JsonProperty(PropertyName = "industry")]
        public string Industry { get; set; }
        
        /// <summary>
        /// Subindustry of the organization
        /// </summary>
        [JsonProperty(PropertyName = "subIndustry")]
        public string SubIndustry { get; set; }
        
        /// <summary>
        /// Whether the organization is on an analytics trial plan
        /// </summary>
        [JsonProperty(PropertyName = "isTrial")]
        public bool? IsTrial { get; set; }
    }

}
