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
    /// SrtToCea608708Caption
    /// </summary>
    public class SrtToCea608708Caption : BitmovinResource
    {
        /// <summary>
        /// Input location of the SRT file (required)
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public InputPath Input { get; set; }

        /// <summary>
        /// The channel number to embed the CEA subtitles in (required)
        /// </summary>
        [JsonProperty(PropertyName = "ccChannel")]
        public Cea608ChannelType? CcChannel { get; set; }

        /// <summary>
        /// Character encoding of the input SRT file (required)
        /// </summary>
        [JsonProperty(PropertyName = "characterEncoding")]
        public CaptionCharacterEncoding? CharacterEncoding { get; set; }
    }
}
