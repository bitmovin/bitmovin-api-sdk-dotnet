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
    /// PcmAudioConfiguration
    /// </summary>
    public class PcmAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "PCM";
#pragma warning restore CS0414

        /// <summary>
        /// Use a set of well defined configurations preset to support certain use cases. Can be overwritten with more specific values.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public PcmPresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// Channel layout of the audio codec configuration
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public PcmChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// Sampling format of the audio codec configuration
        /// </summary>
        [JsonProperty(PropertyName = "sampleFormat")]
        public PcmSampleFormat? SampleFormat { get; set; }
    }
}
