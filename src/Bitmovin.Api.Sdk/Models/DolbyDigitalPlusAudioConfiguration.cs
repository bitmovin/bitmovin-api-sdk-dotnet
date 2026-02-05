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
    /// DolbyDigitalPlusAudioConfiguration
    /// </summary>
    public class DolbyDigitalPlusAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DDPLUS";
#pragma warning restore CS0414

        /// <summary>
        /// BitstreamInfo defines metadata parameters contained in the Dolby Digital Plus audio bitstream
        /// </summary>
        [JsonProperty(PropertyName = "bitstreamInfo")]
        public DolbyDigitalPlusBitstreamInfo BitstreamInfo { get; set; }

        /// <summary>
        /// Channel layout of the audio codec configuration.
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public DolbyDigitalPlusChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// Downmixing
        /// </summary>
        [JsonProperty(PropertyName = "downmixing")]
        public DolbyDigitalPlusDownmixing Downmixing { get; set; }

        /// <summary>
        /// It provides a framework for signaling new evolution framework applications, such as Intelligent Loudness, in each Dolby codec. 
        /// </summary>
        [JsonProperty(PropertyName = "evolutionFrameworkControl")]
        public DolbyDigitalPlusEvolutionFrameworkControl? EvolutionFrameworkControl { get; set; }

        /// <summary>
        /// Settings for loudness control (required)
        /// </summary>
        [JsonProperty(PropertyName = "loudnessControl")]
        public DolbyDigitalPlusLoudnessControl LoudnessControl { get; set; }

        /// <summary>
        /// Preprocessing
        /// </summary>
        [JsonProperty(PropertyName = "preprocessing")]
        public DolbyDigitalPlusPreprocessing Preprocessing { get; set; }
    }
}
