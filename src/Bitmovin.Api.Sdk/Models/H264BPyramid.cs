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
    /// H264BPyramid
    /// </summary>
    public enum H264BPyramid
    {
        /// <summary>
        /// Do not keep b-frame references
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Use a strictly hierarchical pyramid
        /// </summary>
        [EnumMember(Value = "STRICT")]
        STRICT,
        
        /// <summary>
        /// Non-strict, recommended (increases decoding picture buffer)
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        NORMAL
        
    }

}
