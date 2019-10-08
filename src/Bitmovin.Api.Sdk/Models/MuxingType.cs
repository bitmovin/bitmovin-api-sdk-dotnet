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
    /// MuxingType
    /// </summary>
    public enum MuxingType
    {
        /// <summary>
        /// FMP4
        /// </summary>
        [EnumMember(Value = "FMP4")]
        FMP4,
        
        /// <summary>
        /// CMAF
        /// </summary>
        [EnumMember(Value = "CMAF")]
        CMAF,
        
        /// <summary>
        /// MP4
        /// </summary>
        [EnumMember(Value = "MP4")]
        MP4,
        
        /// <summary>
        /// TS
        /// </summary>
        [EnumMember(Value = "TS")]
        TS,
        
        /// <summary>
        /// WEBM
        /// </summary>
        [EnumMember(Value = "WEBM")]
        WEBM,
        
        /// <summary>
        /// MP3
        /// </summary>
        [EnumMember(Value = "MP3")]
        MP3,
        
        /// <summary>
        /// PROGRESSIVEWEBM
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_WEBM")]
        PROGRESSIVEWEBM,
        
        /// <summary>
        /// PROGRESSIVEMOV
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_MOV")]
        PROGRESSIVEMOV,
        
        /// <summary>
        /// PROGRESSIVETS
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_TS")]
        PROGRESSIVETS,
        
        /// <summary>
        /// BROADCASTTS
        /// </summary>
        [EnumMember(Value = "BROADCAST_TS")]
        BROADCASTTS,
        
        /// <summary>
        /// CHUNKEDTEXT
        /// </summary>
        [EnumMember(Value = "CHUNKED_TEXT")]
        CHUNKEDTEXT,
        
        /// <summary>
        /// TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT,
        
        /// <summary>
        /// SEGMENTEDRAW
        /// </summary>
        [EnumMember(Value = "SEGMENTED_RAW")]
        SEGMENTEDRAW
        
    }

}
