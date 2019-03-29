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
    /// Vp9AqMode
    /// </summary>
    public enum Vp9AqMode
    {
        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "VARIANCE")]
        VARIANCE,
        
        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "COMPLEXITY")]
        COMPLEXITY,
        
        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "CYCLIC")]
        CYCLIC
        
    }

}
