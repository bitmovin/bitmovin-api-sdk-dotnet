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
    /// DolbyDigitalAudioConfiguration
    /// </summary>
    public class DolbyDigitalAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DD";
#pragma warning restore CS0414

        /// <summary>
        /// BitstreamInfo defines metadata parameters contained in the Dolby Digital audio bitstream
        /// </summary>
        [JsonProperty(PropertyName = "bitstreamInfo")]
        public DolbyDigitalBitstreamInfo BitstreamInfo { get; set; }

        /// <summary>
        /// Channel layout of the audio codec configuration.
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public DolbyDigitalChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// Downmixing
        /// </summary>
        [JsonProperty(PropertyName = "downmixing")]
        public DolbyDigitalDownmixing Downmixing { get; set; }

        /// <summary>
        /// It provides a framework for signaling new evolution framework applications, such as Intelligent Loudness, in each Dolby codec. 
        /// </summary>
        [JsonProperty(PropertyName = "evolutionFrameworkControl")]
        public DolbyDigitalEvolutionFrameworkControl? EvolutionFrameworkControl { get; set; }

        /// <summary>
        /// Settings for loudness control (required)
        /// </summary>
        [JsonProperty(PropertyName = "loudnessControl")]
        public DolbyDigitalLoudnessControl LoudnessControl { get; set; }

        /// <summary>
        /// Preprocessing
        /// </summary>
        [JsonProperty(PropertyName = "preprocessing")]
        public DolbyDigitalPreprocessing Preprocessing { get; set; }
    }
}
