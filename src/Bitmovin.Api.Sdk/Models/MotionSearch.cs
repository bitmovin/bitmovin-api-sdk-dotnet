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
    /// MotionSearch
    /// </summary>
    public enum MotionSearch
    {
        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "DIA")]
        DIA,
        
        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "HEX")]
        HEX,
        
        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "UMH")]
        UMH,
        
        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "STAR")]
        STAR,
        
        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL
        
    }

}
