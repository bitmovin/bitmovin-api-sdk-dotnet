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
    /// AnalyticsVirtualLicenseRequest
    /// </summary>
    public class AnalyticsVirtualLicenseRequest
    {
        /// <summary>
        /// Name of the Analytics Virtual License (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The timezone of the Analytics Virtual License (required)
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// List of Analytics Licenses (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public List<AnalyticsVirtualLicenseLicensesListItem> Licenses { get; set; } = new List<AnalyticsVirtualLicenseLicensesListItem>();

        /// <summary>
        /// Labels for Custom Data fields
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldLabels")]
        public AnalyticsLicenseCustomDataFieldLabels CustomDataFieldLabels { get; set; }
    }
}
