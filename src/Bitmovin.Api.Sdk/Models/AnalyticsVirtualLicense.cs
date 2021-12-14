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
    /// AnalyticsVirtualLicense
    /// </summary>
    public class AnalyticsVirtualLicense
    {
        /// <summary>
        /// Analytics Virtual License Key/Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Name of the Analytics Virtual License
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The timezone of the Analytics Virtual License
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// List of Analytics Licenses
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public List<AnalyticsVirtualLicenseLicensesListItem> Licenses { get; set; } = new List<AnalyticsVirtualLicenseLicensesListItem>();

        /// <summary>
        /// The number of customData fields available
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldsCount")]
        public int? CustomDataFieldsCount { get; internal set; }

        /// <summary>
        /// Labels for Custom Data fields
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldLabels")]
        public AnalyticsLicenseCustomDataFieldLabels CustomDataFieldLabels { get; set; }
    }
}
