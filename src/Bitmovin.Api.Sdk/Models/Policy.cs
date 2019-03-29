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
    /// Policy
    /// </summary>
    public enum Policy
    {
        /// <summary>
        /// Allows access to given permissions.
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        ALLOW,
        
        /// <summary>
        /// Denies access to given permissions.
        /// </summary>
        [EnumMember(Value = "DENY")]
        DENY
        
    }

}
