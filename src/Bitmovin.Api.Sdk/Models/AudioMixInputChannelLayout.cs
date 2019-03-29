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
    /// AudioMixInputChannelLayout
    /// </summary>
    public enum AudioMixInputChannelLayout
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
        /// Channel layout 4.0
        /// </summary>
        [EnumMember(Value = "4.0")]
        CL_4_0,
        
        /// <summary>
        /// Channel layout 5.0 Back
        /// </summary>
        [EnumMember(Value = "5.0_BACK")]
        CL_5_0_BACK,
        
        /// <summary>
        /// Channel layout 5.1 Back
        /// </summary>
        [EnumMember(Value = "5.1_BACK")]
        CL_5_1_BACK,
        
        /// <summary>
        /// Channel layout 7.1
        /// </summary>
        [EnumMember(Value = "7.1")]
        CL_7_1,
        
        /// <summary>
        /// Channel layout 7.1 Wide Back
        /// </summary>
        [EnumMember(Value = "7.1_WIDE_BACK")]
        CL_7_1_WIDE_BACK
        
    }

}
