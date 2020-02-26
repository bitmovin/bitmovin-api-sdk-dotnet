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
    /// AudioMixFilter
    /// </summary>
    public class AudioMixFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AUDIO_MIX";

        /// <summary>
        /// Channel layout of the audio codec configuration (required)
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public AudioMixChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// List of mixed channels that matches the channel layout (required)
        /// </summary>
        [JsonProperty(PropertyName = "audioMixChannels")]
        public List<AudioMixChannel> AudioMixChannels { get; set; } = new List<AudioMixChannel>();
    }
}
