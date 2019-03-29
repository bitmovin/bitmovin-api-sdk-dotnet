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
    /// InputColorSpace
    /// </summary>
    public enum InputColorSpace
    {
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "RGB")]
        RGB,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "BT709")]
        BT709,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "FCC")]
        FCC,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "BT470BG")]
        BT470BG,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "SMPTE170M")]
        SMPTE170M,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "SMPTE240M")]
        SMPTE240M,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "YCGCO")]
        YCGCO,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "YCOCG")]
        YCOCG,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "BT2020_NCL")]
        BT2020_NCL,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "BT2020_CL")]
        BT2020_CL,
        
        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "SMPTE2085")]
        SMPTE2085
        
    }

}
