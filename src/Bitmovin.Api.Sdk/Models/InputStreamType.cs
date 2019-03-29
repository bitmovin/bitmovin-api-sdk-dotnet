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
    /// InputStreamType
    /// </summary>
    public enum InputStreamType
    {
        /// <summary>
        /// INGEST
        /// </summary>
        [EnumMember(Value = "INGEST")]
        INGEST,
        
        /// <summary>
        /// CONCATENATION
        /// </summary>
        [EnumMember(Value = "CONCATENATION")]
        CONCATENATION,
        
        /// <summary>
        /// TRIMMINGTIMEBASED
        /// </summary>
        [EnumMember(Value = "TRIMMING_TIME_BASED")]
        TRIMMINGTIMEBASED,
        
        /// <summary>
        /// TRIMMINGTIMECODETRACK
        /// </summary>
        [EnumMember(Value = "TRIMMING_TIME_CODE_TRACK")]
        TRIMMINGTIMECODETRACK,
        
        /// <summary>
        /// TRIMMINGH264PICTURETIMING
        /// </summary>
        [EnumMember(Value = "TRIMMING_H264_PICTURE_TIMING")]
        TRIMMINGH264PICTURETIMING,
        
        /// <summary>
        /// AUDIOMIX
        /// </summary>
        [EnumMember(Value = "AUDIO_MIX")]
        AUDIOMIX
        
    }

}
