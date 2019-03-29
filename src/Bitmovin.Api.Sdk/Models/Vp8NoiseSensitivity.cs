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
    /// Vp8NoiseSensitivity
    /// </summary>
    public enum Vp8NoiseSensitivity
    {
        /// <summary>
        /// Noise sensitivity (frames to blur).
        /// </summary>
        [EnumMember(Value = "OFF")]
        OFF,
        
        /// <summary>
        /// Noise sensitivity (frames to blur).
        /// </summary>
        [EnumMember(Value = "ON_Y_ONLY")]
        ON_Y_ONLY,
        
        /// <summary>
        /// Noise sensitivity (frames to blur).
        /// </summary>
        [EnumMember(Value = "ON_YUV")]
        ON_YUV,
        
        /// <summary>
        /// Noise sensitivity (frames to blur).
        /// </summary>
        [EnumMember(Value = "ON_YUV_AGGRESSIVE")]
        ON_YUV_AGGRESSIVE,
        
        /// <summary>
        /// Noise sensitivity (frames to blur).
        /// </summary>
        [EnumMember(Value = "ADAPTIVE")]
        ADAPTIVE
        
    }

}
