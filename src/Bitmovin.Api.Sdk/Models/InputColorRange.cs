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
    /// InputColorRange
    /// </summary>
    public enum InputColorRange
    {
        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,
        
        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "MPEG")]
        MPEG,
        
        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG
        
    }

}
