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
    /// EncodingMode
    /// </summary>
    public enum EncodingMode
    {
        /// <summary>
        /// The standard encoding mode is currently TWO_PASS
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD,
        
        /// <summary>
        /// Single pass encoding
        /// </summary>
        [EnumMember(Value = "SINGLE_PASS")]
        SINGLE_PASS,
        
        /// <summary>
        /// Two pass encoding for better quality
        /// </summary>
        [EnumMember(Value = "TWO_PASS")]
        TWO_PASS,
        
        /// <summary>
        /// Three pass encoding for best quality (this only works for VoD workflows)
        /// </summary>
        [EnumMember(Value = "THREE_PASS")]
        THREE_PASS
        
    }

}
