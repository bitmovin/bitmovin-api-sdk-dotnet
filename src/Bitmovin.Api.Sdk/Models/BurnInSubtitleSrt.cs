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
    /// BurnInSubtitleSrt
    /// </summary>

    public class BurnInSubtitleSrt : BitmovinResource
    {
        /// <summary>
        /// Character encoding of the SRT file (required)
        /// </summary>
        [JsonProperty(PropertyName = "characterEncoding")]
        public CaptionCharacterEncoding? CharacterEncoding { get; set; }
        
        /// <summary>
        /// The input location to get the SRT file from (required)
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public InputPath Input { get; set; }
    }

}
