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
    /// PaddingDurationUnit
    /// </summary>
    public enum PaddingDurationUnit
    {
        /// <summary>
        /// Duration will be specified in seconds
        /// </summary>
        [EnumMember(Value = "SECONDS")]
        SECONDS,
        
        /// <summary>
        /// Duration will be specified in number of frames
        /// </summary>
        [EnumMember(Value = "FRAMES")]
        FRAMES
        
    }

}
