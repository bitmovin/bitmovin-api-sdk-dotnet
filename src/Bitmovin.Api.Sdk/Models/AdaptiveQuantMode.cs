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
    /// AdaptiveQuantMode
    /// </summary>
    public enum AdaptiveQuantMode
    {
        /// <summary>
        /// Disable adaptive quantization
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Redistributes bits within each frame
        /// </summary>
        [EnumMember(Value = "VARIANCE")]
        VARIANCE,
        
        /// <summary>
        /// Redistributes bits across the whole video
        /// </summary>
        [EnumMember(Value = "AUTO_VARIANCE")]
        AUTO_VARIANCE,
        
        /// <summary>
        /// Redistributes bits across the whole video with a bias to dark scenes
        /// </summary>
        [EnumMember(Value = "AUTO_VARIANCE_DARK_SCENES")]
        AUTO_VARIANCE_DARK_SCENES
        
    }

}
