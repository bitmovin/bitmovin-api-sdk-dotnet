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
    /// ChunkLengthMode
    /// </summary>
    public enum ChunkLengthMode
    {
        /// <summary>
        /// The chunk length is optimized for fast turnaround times
        /// </summary>
        [EnumMember(Value = "SPEED_OPTIMIZED")]
        SPEED_OPTIMIZED,
        
        /// <summary>
        /// The chunk length is defined by the customChunkLength attribute
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM
        
    }

}
