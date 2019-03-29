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
    /// AnalyticsLicenseDetails
    /// </summary>

    public class AnalyticsLicenseDetails : BitmovinResource
    {
        /// <summary>
        /// License Key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
        
        /// <summary>
        /// Maximum number of datapoints
        /// </summary>
        [JsonProperty(PropertyName = "maxDatapoints")]
        public long? MaxDatapoints { get; set; }
        
        /// <summary>
        /// Number of datapoints recorded
        /// </summary>
        [JsonProperty(PropertyName = "datapoints")]
        public long? Datapoints { get; set; }
        
        /// <summary>
        /// Whitelisted domains
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public List<AnalyticsLicenseDomain> Domains { get; set; }
    }

}
