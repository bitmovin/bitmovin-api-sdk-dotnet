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
        private readonly string _type = "DOLBY_ATMOS";

        /// <summary>
        /// Settings for loudness control (required)
        /// </summary>
        [JsonProperty(PropertyName = "loudnessControl")]
        public DolbyAtmosLoudnessControl LoudnessControl { get; set; }
    }
}
