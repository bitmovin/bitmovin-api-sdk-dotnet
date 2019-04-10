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
    /// LimitTransformUnitDepthRecursionMode
    /// </summary>
    public enum LimitTransformUnitDepthRecursionMode
    {
        /// <summary>
        /// Disable early exit from transform unit dept recursion
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Decides to recurse to next higher depth based on cost comparison of full size transform unit and split transform unit.
        /// </summary>
        [EnumMember(Value = "LEVEL_1")]
        LEVEL_1,
        
        /// <summary>
        /// Based on first split sub TUs depth, limits recursion of other split sub TUs.
        /// </summary>
        [EnumMember(Value = "LEVEL_2")]
        LEVEL_2,
        
        /// <summary>
        /// Based on the average depth of the co-located and the neighbor CUs TU depth, limits recursion of the current CU.
        /// </summary>
        [EnumMember(Value = "LEVEL_3")]
        LEVEL_3,
        
        /// <summary>
        /// Uses the depth of the co-located CUs TU depth to limit the 1st sub TU depth. The 1st sub TU depth is taken as the limiting depth for the other sub TUs.
        /// </summary>
        [EnumMember(Value = "LEVEL_4")]
        LEVEL_4
        
    }

}
