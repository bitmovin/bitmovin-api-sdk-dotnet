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
    /// LiveEncodingCodec
    /// </summary>
    public enum LiveEncodingCodec
    {
        /// <summary>
        /// H264
        /// </summary>
        [EnumMember(Value = "H264")]
        H264,
        
        /// <summary>
        /// H265
        /// </summary>
        [EnumMember(Value = "H265")]
        H265,
        
        /// <summary>
        /// AAC
        /// </summary>
        [EnumMember(Value = "AAC")]
        AAC
        
    }

}
