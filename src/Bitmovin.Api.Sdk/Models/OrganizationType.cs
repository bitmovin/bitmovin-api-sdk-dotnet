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
    /// OrganizationType
    /// </summary>
    public enum OrganizationType
    {
        /// <summary>
        /// ROOTORGANIZATION
        /// </summary>
        [EnumMember(Value = "ROOT_ORGANIZATION")]
        ROOTORGANIZATION,
        
        /// <summary>
        /// SUBORGANIZATION
        /// </summary>
        [EnumMember(Value = "SUB_ORGANIZATION")]
        SUBORGANIZATION
        
    }

}
