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
    /// PlayerThirdPartyLicensingErrorAction
    /// </summary>
    public enum PlayerThirdPartyLicensingErrorAction
    {
        /// <summary>
        /// Allow the licensing request if the Third Party Licensing server returns anything other than HTTP 2xx.
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        ALLOW,
        
        /// <summary>
        /// Deny the licensing request if the Third Party Licensing server returns anything other than HTTP 2xx.
        /// </summary>
        [EnumMember(Value = "DENY")]
        DENY
        
    }

}
