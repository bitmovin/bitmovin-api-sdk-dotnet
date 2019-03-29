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
    /// H264MotionEstimationMethod
    /// </summary>
    public enum H264MotionEstimationMethod
    {
        /// <summary>
        /// diamond search, radius 1 (fast)
        /// </summary>
        [EnumMember(Value = "DIA")]
        DIA,
        
        /// <summary>
        /// hexagonal search, radius 2
        /// </summary>
        [EnumMember(Value = "HEX")]
        HEX,
        
        /// <summary>
        /// uneven multi-hexagon search
        /// </summary>
        [EnumMember(Value = "UMH")]
        UMH,
        
        /// <summary>
        /// exhaustive search
        /// </summary>
        [EnumMember(Value = "ESA")]
        ESA,
        
        /// <summary>
        /// hadamard exhaustive search (slow)
        /// </summary>
        [EnumMember(Value = "TESA")]
        TESA
        
    }

}
