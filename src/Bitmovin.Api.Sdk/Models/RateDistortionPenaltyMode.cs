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
    /// RateDistortionPenaltyMode
    /// </summary>
    public enum RateDistortionPenaltyMode
    {
        /// <summary>
        /// Rate distortion penalty disabled.
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Transform units of size 32x32 are given a 4x bit cost penalty compared to smaller transform units, in intra coded CUs in P or B slices.
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        NORMAL,
        
        /// <summary>
        /// Transform units of size 32x32 are not even attempted, unless otherwise required by the maximum recursion depth.
        /// </summary>
        [EnumMember(Value = "MAXIMUM")]
        MAXIMUM
        
    }

}
