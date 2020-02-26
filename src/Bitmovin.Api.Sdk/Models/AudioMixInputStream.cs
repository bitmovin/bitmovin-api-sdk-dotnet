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
    /// AudioMixInputStream
    /// </summary>
    public class AudioMixInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AUDIO_MIX";

        /// <summary>
        /// Channel layout of the audio mix input stream
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public AudioMixInputChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// AudioMixChannels
        /// </summary>
        [JsonProperty(PropertyName = "audioMixChannels")]
        public List<AudioMixInputStreamChannel> AudioMixChannels { get; set; } = new List<AudioMixInputStreamChannel>();
    }
}
