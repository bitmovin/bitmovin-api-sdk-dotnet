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
    /// BAdapt
    /// </summary>
    public enum BAdapt
    {
        /// <summary>
        /// Very fast, but not recommended
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// A good balance between speed and quality
        /// </summary>
        [EnumMember(Value = "FAST")]
        FAST,
        
        /// <summary>
        /// Best Quality, but slow with high bframes
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL
        
    }

}
