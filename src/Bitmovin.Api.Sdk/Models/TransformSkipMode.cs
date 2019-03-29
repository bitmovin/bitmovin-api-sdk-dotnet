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
    /// TransformSkipMode
    /// </summary>
    public enum TransformSkipMode
    {
        /// <summary>
        /// No transform skip enabled
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Enable normal evaluation of transform skip
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        NORMAL,
        
        /// <summary>
        /// Only evaluate transform skip for NxN intra predictions (4x4 blocks).
        /// </summary>
        [EnumMember(Value = "FAST")]
        FAST
        
    }

}
