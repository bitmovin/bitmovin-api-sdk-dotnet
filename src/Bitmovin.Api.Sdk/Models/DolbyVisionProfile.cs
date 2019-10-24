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
    /// DolbyVisionProfile
    /// </summary>
    public enum DolbyVisionProfile
    {
        /// <summary>
        /// dvhe.04
        /// </summary>
        [EnumMember(Value = "DVHE_04")]
        DVHE_04,
        
        /// <summary>
        /// dvhe.05
        /// </summary>
        [EnumMember(Value = "DVHE_05")]
        DVHE_05,
        
        /// <summary>
        /// dvhe.07
        /// </summary>
        [EnumMember(Value = "DVHE_07")]
        DVHE_07,
        
        /// <summary>
        /// hev1.08
        /// </summary>
        [EnumMember(Value = "HEV1_08")]
        HEV1_08,
        
        /// <summary>
        /// avc3.09
        /// </summary>
        [EnumMember(Value = "AVC3_09")]
        AVC3_09
        
    }

}
