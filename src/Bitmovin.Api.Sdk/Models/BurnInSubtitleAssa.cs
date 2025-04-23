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
    /// BurnInSubtitleAssa
    /// </summary>
    public class BurnInSubtitleAssa : BitmovinResource
    {
        /// <summary>
        /// Character encoding of the ASSA file (required)
        /// </summary>
        [JsonProperty(PropertyName = "characterEncoding")]
        public CaptionCharacterEncoding? CharacterEncoding { get; set; }

        /// <summary>
        /// The input location to get the ASSA file from (required)
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public InputPath Input { get; set; }
    }
}
