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
    /// AnalyticsLicense
    /// </summary>
    public class AnalyticsLicense : BitmovinResponse
    {
        /// <summary>
        /// Name of the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// License Key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; internal set; }

        /// <summary>
        /// Creation date of the Analytics License in UTC format
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Maximum number of impressions
        /// </summary>
        [JsonProperty(PropertyName = "maxImpressions")]
        public long? MaxImpressions { get; internal set; }

        /// <summary>
        /// Number of impressions recorded
        /// </summary>
        [JsonProperty(PropertyName = "impressions")]
        public long? Impressions { get; internal set; }

        /// <summary>
        /// Whitelisted domains
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public List<AnalyticsLicenseDomain> Domains { get; internal set; } = new List<AnalyticsLicenseDomain>();

        /// <summary>
        /// Whether the Do Not Track request from the browser should be ignored
        /// </summary>
        [JsonProperty(PropertyName = "ignoreDNT")]
        public bool? IgnoreDNT { get; internal set; }

        /// <summary>
        /// The timezone of the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; internal set; }

        /// <summary>
        /// Labels for CustomData fields
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldLabels")]
        public AnalyticsLicenseCustomDataFieldLabels CustomDataFieldLabels { get; set; }

        /// <summary>
        /// Features
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public AnalyticsLicenseFeatures Features { get; set; }
    }
}
