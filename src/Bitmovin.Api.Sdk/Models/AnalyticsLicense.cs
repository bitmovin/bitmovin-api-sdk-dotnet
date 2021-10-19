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
    public class AnalyticsLicense
    {
        /// <summary>
        /// Id of the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Creation date of the Analytics License in UTC format
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// User-specific meta data. This can hold anything.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public Dictionary<string, Object> CustomData { get; internal set; } = new Dictionary<string, Object>();

        /// <summary>
        /// License Key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; internal set; }

        /// <summary>
        /// Name of the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The industry of the organization associated with the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "industry")]
        public string Industry { get; internal set; }

        /// <summary>
        /// The subindustry of the organization associated with the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "subIndustry")]
        public string SubIndustry { get; internal set; }

        /// <summary>
        /// Whether the Do Not Track request from the browser should be ignored
        /// </summary>
        [JsonProperty(PropertyName = "ignoreDNT")]
        public bool? IgnoreDNT { get; set; }

        /// <summary>
        /// Number of impressions recorded
        /// </summary>
        [JsonProperty(PropertyName = "impressions")]
        public long? Impressions { get; internal set; }

        /// <summary>
        /// Maximum number of impressions
        /// </summary>
        [JsonProperty(PropertyName = "maxImpressions")]
        public long? MaxImpressions { get; internal set; }

        /// <summary>
        /// The timezone of the Analytics License
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Retention time of impressions, returned as ISO 8601 duration format: P(n)Y(n)M(n)DT(n)H(n)M(n)S
        /// </summary>
        [JsonProperty(PropertyName = "retentionTime")]
        public string RetentionTime { get; internal set; }

        /// <summary>
        /// Whitelisted domains
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public List<AnalyticsLicenseDomain> Domains { get; internal set; } = new List<AnalyticsLicenseDomain>();

        /// <summary>
        /// Whether the data of this license should be included in the industry insights or not
        /// </summary>
        [JsonProperty(PropertyName = "includeInInsights")]
        public bool? IncludeInInsights { get; internal set; }

        /// <summary>
        /// Labels for CustomData fields
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldLabels")]
        public AnalyticsLicenseCustomDataFieldLabels CustomDataFieldLabels { get; set; }

        /// <summary>
        /// The number of customData fields available
        /// </summary>
        [JsonProperty(PropertyName = "customDataFieldsCount")]
        public int? CustomDataFieldsCount { get; internal set; }

        /// <summary>
        /// Order index of license
        /// </summary>
        [JsonProperty(PropertyName = "orderIndex")]
        public int? OrderIndex { get; internal set; }

        /// <summary>
        /// The rate limit of this license
        /// </summary>
        [JsonProperty(PropertyName = "rateLimit")]
        public string RateLimit { get; set; }

        /// <summary>
        /// Features
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public AnalyticsLicenseFeatures Features { get; set; }
    }
}
