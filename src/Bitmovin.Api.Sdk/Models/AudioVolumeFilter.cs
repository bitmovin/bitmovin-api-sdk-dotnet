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
    /// AudioVolumeFilter
    /// </summary>
    public class AudioVolumeFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AUDIO_VOLUME";

        /// <summary>
        /// Audio volume value (required)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public AudioVolumeUnit? Unit { get; set; }
    }
}
