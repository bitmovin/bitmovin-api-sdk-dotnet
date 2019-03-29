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
    /// VorbisChannelLayout
    /// </summary>
    public enum VorbisChannelLayout
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
        /// Channel Layout 2.1
        /// </summary>
        [EnumMember(Value = "2.1")]
        CL_2_1,
        
        /// <summary>
        /// Channel Layout 2.2
        /// </summary>
        [EnumMember(Value = "2.2")]
        CL_2_2,
        
        /// <summary>
        /// Channel Layout 3.1
        /// </summary>
        [EnumMember(Value = "3.1")]
        CL_3_1,
        
        /// <summary>
        /// Channel Layout 4.0
        /// </summary>
        [EnumMember(Value = "4.0")]
        CL_4_0,
        
        /// <summary>
        /// Channel Layout 5.1
        /// </summary>
        [EnumMember(Value = "5.1")]
        CL_5_1,
        
        /// <summary>
        /// Channel Layout 5.1 Back
        /// </summary>
        [EnumMember(Value = "5.1_BACK")]
        CL_5_1_BACK
        
    }

}
