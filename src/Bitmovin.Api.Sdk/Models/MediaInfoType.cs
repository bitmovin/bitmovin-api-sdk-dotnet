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
    /// MediaInfoType
    /// </summary>
    public enum MediaInfoType
    {
        /// <summary>
        /// AUDIO
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO,
        
        /// <summary>
        /// VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,
        
        /// <summary>
        /// SUBTITLES
        /// </summary>
        [EnumMember(Value = "SUBTITLES")]
        SUBTITLES,
        
        /// <summary>
        /// CLOSEDCAPTIONS
        /// </summary>
        [EnumMember(Value = "CLOSED_CAPTIONS")]
        CLOSEDCAPTIONS,
        
        /// <summary>
        /// VTT
        /// </summary>
        [EnumMember(Value = "VTT")]
        VTT
        
    }

}
