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
    /// OpusChannelLayout
    /// </summary>
    public enum OpusChannelLayout
    {
        /// <summary>
        /// No channel Layout
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Channel Layout Mono
        /// </summary>
        [EnumMember(Value = "MONO")]
        MONO,
        
        /// <summary>
        /// Channel Layout Stereo
        /// </summary>
        [EnumMember(Value = "STEREO")]
        CL_STEREO,
        
        /// <summary>
        /// Channel Layout Surround
        /// </summary>
        [EnumMember(Value = "SURROUND")]
        CL_SURROUND,
        
        /// <summary>
        /// Channel Layout Quad
        /// </summary>
        [EnumMember(Value = "QUAD")]
        CL_QUAD,
        
        /// <summary>
        /// Channel Layout 4.1
        /// </summary>
        [EnumMember(Value = "4.1")]
        CL_4_1,
        
        /// <summary>
        /// Channel Layout 5.0 Back
        /// </summary>
        [EnumMember(Value = "5.0_BACK")]
        CL_5_0_BACK,
        
        /// <summary>
        /// Channel Layout 5.1 Back
        /// </summary>
        [EnumMember(Value = "5.1_BACK")]
        XCL_5_1_BACK,
        
        /// <summary>
        /// Channel Layout 6.1
        /// </summary>
        [EnumMember(Value = "6.1")]
        CL_6_1,
        
        /// <summary>
        /// Channel Layout 7.1
        /// </summary>
        [EnumMember(Value = "7.1")]
        CL_7_1
        
    }

}
