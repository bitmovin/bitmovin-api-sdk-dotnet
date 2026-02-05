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
    /// Eac3AudioConfiguration
    /// </summary>
    public class Eac3AudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "EAC3";
#pragma warning restore CS0414

        /// <summary>
        /// Channel layout of the audio codec configuration
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public Ac3ChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// The highest frequency that will pass the audio encoder. This value is optional.
        /// </summary>
        [JsonProperty(PropertyName = "cutoffFrequency")]
        public int? CutoffFrequency { get; set; }
    }
}
