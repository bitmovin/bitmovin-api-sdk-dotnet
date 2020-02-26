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
    /// MuxingInformationAudioTrack
    /// </summary>
    public class MuxingInformationAudioTrack
    {
        /// <summary>
        /// The stream index in the container
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; internal set; }

        /// <summary>
        /// The codec used for the track
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; internal set; }

        /// <summary>
        /// The codec string of the track
        /// </summary>
        [JsonProperty(PropertyName = "codecIso")]
        public string CodecIso { get; internal set; }

        /// <summary>
        /// The bitrate of the audio track
        /// </summary>
        [JsonProperty(PropertyName = "bitRate")]
        public long? BitRate { get; internal set; }

        /// <summary>
        /// Rate
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public long? Rate { get; internal set; }

        /// <summary>
        /// The sampling rate of the audio stream
        /// </summary>
        [JsonProperty(PropertyName = "sampleRate")]
        public int? SampleRate { get; internal set; }

        /// <summary>
        /// The number of channels in this audio stream
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public int? Channels { get; internal set; }

        /// <summary>
        /// TODO add description
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; internal set; }
    }
}
