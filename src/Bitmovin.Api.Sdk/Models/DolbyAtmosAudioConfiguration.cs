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
    /// DolbyAtmosAudioConfiguration
    /// </summary>
    public class DolbyAtmosAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DOLBY_ATMOS";
#pragma warning restore CS0414

        /// <summary>
        /// Settings for loudness control (required)
        /// </summary>
        [JsonProperty(PropertyName = "loudnessControl")]
        public DolbyAtmosLoudnessControl LoudnessControl { get; set; }

        /// <summary>
        /// Preprocessing
        /// </summary>
        [JsonProperty(PropertyName = "preprocessing")]
        public DolbyAtmosPreprocessing Preprocessing { get; set; }
    }
}
