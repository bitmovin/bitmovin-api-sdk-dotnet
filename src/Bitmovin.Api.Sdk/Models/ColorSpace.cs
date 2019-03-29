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
    /// ColorSpace
    /// </summary>
    public enum ColorSpace
    {
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "RGB")]
        RGB,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "BT709")]
        BT709,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "FCC")]
        FCC,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "BT470BG")]
        BT470BG,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "SMPTE170M")]
        SMPTE170M,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "SMPTE240M")]
        SMPTE240M,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "YCGCO")]
        YCGCO,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "YCOCG")]
        YCOCG,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "BT2020_NCL")]
        BT2020_NCL,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "BT2020_CL")]
        BT2020_CL,
        
        /// <summary>
        /// The color space to be applied
        /// </summary>
        [EnumMember(Value = "SMPTE2085")]
        SMPTE2085
        
    }

}
