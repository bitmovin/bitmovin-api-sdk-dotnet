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
    /// ScalingAlgorithm
    /// </summary>
    public enum ScalingAlgorithm
    {
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "FAST_BILINEAR")]
        FASTBILINEAR,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "BILINEAR")]
        BILINEAR,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "BICUBIC")]
        BICUBIC,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "EXPERIMENTAL")]
        EXPERIMENTAL,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "NEAREST_NEIGHBOR")]
        NEARESTNEIGHBOR,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "AVERAGING_AREA")]
        AVERAGINGAREA,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "BICUBIC_LUMA_BILINEAR_CHROMA")]
        BICUBICLUMABILINEARCHROMA,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "GAUSS")]
        GAUSS,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "SINC")]
        SINC,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "LANCZOS")]
        LANCZOS,
        
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "SPLINE")]
        SPLINE
        
    }

}
