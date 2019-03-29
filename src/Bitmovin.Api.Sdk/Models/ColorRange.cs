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
    /// ColorRange
    /// </summary>
    public enum ColorRange
    {
        /// <summary>
        /// The color range to be applied
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,
        
        /// <summary>
        /// The color range to be applied
        /// </summary>
        [EnumMember(Value = "MPEG")]
        MPEG,
        
        /// <summary>
        /// The color range to be applied
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG
        
    }

}
