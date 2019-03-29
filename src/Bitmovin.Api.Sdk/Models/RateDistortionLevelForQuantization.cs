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
    /// RateDistortionLevelForQuantization
    /// </summary>
    public enum RateDistortionLevelForQuantization
    {
        /// <summary>
        /// Rate-distortion cost is not considered in quantization.
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Rate-distortion cost is used to find optimal rounding values for each level.
        /// </summary>
        [EnumMember(Value = "LEVELS")]
        LEVELS,
        
        /// <summary>
        /// Rate-distortion cost is used to make decimate decisions on each 4x4 coding group.
        /// </summary>
        [EnumMember(Value = "LEVELS_AND_CODING_GROUPS")]
        LEVELS_AND_CODING_GROUPS
        
    }

}
