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
    /// PlayerLicense
    /// </summary>

    public class PlayerLicense : BitmovinResponse
    {
        /// <summary>
        /// Name of the resource (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Creation timestamp formatted in UTC: YYYY-MM-DDThh:mm:ssZ (required)
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }
        
        /// <summary>
        /// License Key (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; internal set; }
        
        /// <summary>
        /// Number of impressions recorded (required)
        /// </summary>
        [JsonProperty(PropertyName = "impressions")]
        public int? Impressions { get; internal set; }
        
        /// <summary>
        /// Maximum number of impressions (required)
        /// </summary>
        [JsonProperty(PropertyName = "maxImpressions")]
        public int? MaxImpressions { get; internal set; }
        
        /// <summary>
        /// Flag if third party licensing is enabled (required)
        /// </summary>
        [JsonProperty(PropertyName = "thirdPartyLicensingEnabled")]
        public bool? ThirdPartyLicensingEnabled { get; internal set; }
        
        /// <summary>
        /// Whitelisted domains (required)
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public List<Domain> Domains { get; internal set; } = new List<Domain>();
        
        /// <summary>
        /// Analytics License Key
        /// </summary>
        [JsonProperty(PropertyName = "analyticsKey")]
        public string AnalyticsKey { get; internal set; }
    }

}
