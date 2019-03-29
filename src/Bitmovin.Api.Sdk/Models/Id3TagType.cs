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
    /// Id3TagType
    /// </summary>
    public enum Id3TagType
    {
        /// <summary>
        /// RAW
        /// </summary>
        [EnumMember(Value = "RAW")]
        RAW,
        
        /// <summary>
        /// FRAMEID
        /// </summary>
        [EnumMember(Value = "FRAME_ID")]
        FRAMEID,
        
        /// <summary>
        /// PLAINTEXT
        /// </summary>
        [EnumMember(Value = "PLAIN_TEXT")]
        PLAINTEXT
        
    }

}
