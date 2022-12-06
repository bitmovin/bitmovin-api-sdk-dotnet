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
    /// H262VideoConfiguration
    /// </summary>
    public class H262VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "H262";

        /// <summary>
        /// Use a set of well defined configurations preset to support certain use cases. Can be overwritten with more specific values.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public H262PresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// When setting a profile, all other settings must not exceed the limits which are defined in the profile. Otherwise, a higher profile may be automatically chosen. (required)
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public ProfileH262? Profile { get; set; }

        /// <summary>
        /// Amount of b frames.
        /// </summary>
        [JsonProperty(PropertyName = "bframes")]
        public int? Bframes { get; set; }

        /// <summary>
        /// Maximum Bitrate
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrate")]
        public long? MaxBitrate { get; set; }

        /// <summary>
        /// Minimum Bitrate
        /// </summary>
        [JsonProperty(PropertyName = "minBitrate")]
        public long? MinBitrate { get; set; }

        /// <summary>
        /// Playback device buffer size
        /// </summary>
        [JsonProperty(PropertyName = "bufsize")]
        public long? Bufsize { get; set; }

        /// <summary>
        /// Minimum GOP length, the minimum distance between I-frames
        /// </summary>
        [JsonProperty(PropertyName = "gopSize")]
        public int? GopSize { get; set; }

        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public LevelH262? Level { get; set; }

        /// <summary>
        /// Using TOP_FIELD_FIRST or BOTTOM_FIELD_FIRST will output interlaced video
        /// </summary>
        [JsonProperty(PropertyName = "interlaceMode")]
        public H262InterlaceMode? InterlaceMode { get; set; }
    }
}
