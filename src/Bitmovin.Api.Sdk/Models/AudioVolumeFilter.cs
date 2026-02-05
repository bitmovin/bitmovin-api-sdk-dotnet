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
#pragma warning disable CS0414
        private readonly string _type = "AUDIO_VOLUME";
#pragma warning restore CS0414

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

        /// <summary>
        /// Format
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public AudioVolumeFormat? Format { get; set; }
    }
}
