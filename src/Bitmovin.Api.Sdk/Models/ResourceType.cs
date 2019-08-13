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
    /// ResourceType
    /// </summary>
    public enum ResourceType
    {
        /// <summary>
        /// Account
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        
        /// <summary>
        /// Encoding
        /// </summary>
        [EnumMember(Value = "encoding")]
        Encoding,
        
        /// <summary>
        /// Player
        /// </summary>
        [EnumMember(Value = "player")]
        Player,
        
        /// <summary>
        /// Analytics
        /// </summary>
        [EnumMember(Value = "analytics")]
        Analytics
        
    }

}
