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
    /// H264NalHrd
    /// </summary>
    public enum H264NalHrd
    {
        /// <summary>
        /// Do not signal HRD information
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Signal HRD for variable bitrate
        /// </summary>
        [EnumMember(Value = "VBR")]
        VBR,
        
        /// <summary>
        /// Signal HRD for constant bitrate (Not possible with fragmented or progressive MP4 muxings)
        /// </summary>
        [EnumMember(Value = "CBR")]
        CBR
        
    }

}
