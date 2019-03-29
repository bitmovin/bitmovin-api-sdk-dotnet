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
    /// AclPermission
    /// </summary>
    public enum AclPermission
    {
        /// <summary>
        /// PUBLICREAD
        /// </summary>
        [EnumMember(Value = "PUBLIC_READ")]
        PUBLICREAD,
        
        /// <summary>
        /// PRIVATE
        /// </summary>
        [EnumMember(Value = "PRIVATE")]
        PRIVATE
        
    }

}
