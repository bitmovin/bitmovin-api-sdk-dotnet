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
    /// PlayerThirdPartyLicensing
    /// </summary>

    public class PlayerThirdPartyLicensing
    {
        /// <summary>
        /// URL to your license check server
        /// </summary>
        [JsonProperty(PropertyName = "licenseCheckServer")]
        public string LicenseCheckServer { get; set; }
        
        /// <summary>
        /// Timeout in ms
        /// </summary>
        [JsonProperty(PropertyName = "licenseCheckTimeout")]
        public int? LicenseCheckTimeout { get; set; }
        
        /// <summary>
        /// Specify if the Licensing Request should fail or not on Third Party Licensing Error
        /// </summary>
        [JsonProperty(PropertyName = "errorAction")]
        public PlayerThirdPartyLicensingErrorAction ErrorAction { get; set; }
        
        /// <summary>
        /// Specify if the Licensing Request should fail or not on Third Party Licensing timeout
        /// </summary>
        [JsonProperty(PropertyName = "timeoutAction")]
        public PlayerThirdPartyLicensingErrorAction TimeoutAction { get; set; }
    }

}
