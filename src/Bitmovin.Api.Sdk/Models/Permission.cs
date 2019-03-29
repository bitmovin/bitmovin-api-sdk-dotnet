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
    /// Permission
    /// </summary>
    public enum Permission
    {
        /// <summary>
        /// Permission to call http GET on the defined resource.
        /// </summary>
        [EnumMember(Value = "GET")]
        GET,
        
        /// <summary>
        /// Permission to call http DELETE on the defined resource.
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE,
        
        /// <summary>
        /// Permission to call http POST on the defined resource.
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,
        
        /// <summary>
        /// Permission to call http PUT on the defined resource.
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT,
        
        /// <summary>
        /// Permission to call http PATCH on the defined resource.
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH
        
    }

}
