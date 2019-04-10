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
    /// CmafMuxing
    /// </summary>

    public class CmafMuxing : Fmp4Muxing
    {
        /// <summary>
        /// Number of media frames per CMAF chunk. Defaults to: Length of a segment in frames. Minimum: 1. Maximum: Length of a segment in frames.
        /// </summary>
        [JsonProperty(PropertyName = "framesPerCmafChunk")]
        public Object FramesPerCmafChunk { get; set; }
    }

}
