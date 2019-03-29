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
    /// ForceFlushMode
    /// </summary>
    public enum ForceFlushMode
    {
        /// <summary>
        /// Flush the encoder only when all the input pictures are over
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Flush all the frames even when the input is not over
        /// </summary>
        [EnumMember(Value = "ALL_FRAMES")]
        ALL_FRAMES,
        
        /// <summary>
        /// Flush the slicetype decided frames only
        /// </summary>
        [EnumMember(Value = "SLICE_TYPE")]
        SLICE_TYPE
        
    }

}
