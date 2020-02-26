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
    /// AnalyticsLicenseKey
    /// </summary>
    public class AnalyticsLicenseKey
    {
        /// <summary>
        /// Analytics License Key (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
    }
}
