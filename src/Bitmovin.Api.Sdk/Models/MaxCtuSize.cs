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
    /// MaxCtuSize
    /// </summary>
    public enum MaxCtuSize
    {
        /// <summary>
        /// Set the maximal CTU (Coding Tree Unit) size
        /// </summary>
        [EnumMember(Value = "16")]
        S16,
        
        /// <summary>
        /// Set the maximal CTU (Coding Tree Unit) size
        /// </summary>
        [EnumMember(Value = "32")]
        S32,
        
        /// <summary>
        /// Set the maximal CTU (Coding Tree Unit) size
        /// </summary>
        [EnumMember(Value = "64")]
        S64
        
    }

}
