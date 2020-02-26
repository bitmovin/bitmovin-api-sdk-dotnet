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
    /// AnalyticsLicenseUpdateRequest
    /// </summary>
    public class AnalyticsLicenseUpdateRequest
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// IgnoreDNT
        /// </summary>
        [JsonProperty(PropertyName = "ignoreDNT")]
        public bool? IgnoreDNT { get; set; }

        /// <summary>
        /// TimeZone
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Labels for CustomData fields
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldLabels")]
        public AnalyticsLicenseCustomDataFieldLabels CustomDataFieldLabels { get; set; }
    }
}
