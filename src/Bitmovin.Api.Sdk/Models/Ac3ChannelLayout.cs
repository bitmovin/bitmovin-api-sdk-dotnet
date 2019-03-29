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
    /// Ac3ChannelLayout
    /// </summary>
    public enum Ac3ChannelLayout
    {
        /// <summary>
        /// No channel layout
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Channel layout Mono
        /// </summary>
        [EnumMember(Value = "MONO")]
        MONO,
        
        /// <summary>
        /// Channel layout Stereo
        /// </summary>
        [EnumMember(Value = "STEREO")]
        CL_STEREO,
        
        /// <summary>
        /// Channel layout Surround
        /// </summary>
        [EnumMember(Value = "SURROUND")]
        CL_SURROUND,
        
        /// <summary>
        /// Channel layout Quad
        /// </summary>
        [EnumMember(Value = "QUAD")]
        CL_QUAD,
        
        /// <summary>
        /// Channel layout 2.1
        /// </summary>
        [EnumMember(Value = "2.1")]
        CL_2_1,
        
        /// <summary>
        /// Channel layout 2.2
        /// </summary>
        [EnumMember(Value = "2.2")]
        CL_2_2,
        
        /// <summary>
        /// Channel layout 3.1
        /// </summary>
        [EnumMember(Value = "3.1")]
        CL_3_1,
        
        /// <summary>
        /// Channel layout 4.0
        /// </summary>
        [EnumMember(Value = "4.0")]
        CL_4_0,
        
        /// <summary>
        /// Channel layout 4.1
        /// </summary>
        [EnumMember(Value = "4.1")]
        CL_4_1,
        
        /// <summary>
        /// Channel layout 5.0
        /// </summary>
        [EnumMember(Value = "5.0")]
        CL_5_0,
        
        /// <summary>
        /// Channel layout 5.0 Back
        /// </summary>
        [EnumMember(Value = "5.0_BACK")]
        CL_5_0_BACK,
        
        /// <summary>
        /// Channel layout 5.1
        /// </summary>
        [EnumMember(Value = "5.1")]
        CL_5_1,
        
        /// <summary>
        /// Channel layout 5.1 Back
        /// </summary>
        [EnumMember(Value = "5.1_BACK")]
        CL_5_1_BACK
        
    }

}
