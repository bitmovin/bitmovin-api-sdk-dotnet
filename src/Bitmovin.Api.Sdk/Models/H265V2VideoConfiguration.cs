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
    /// H265V2VideoConfiguration
    /// </summary>
    public class H265V2VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "H265V2";
#pragma warning restore CS0414

        /// <summary>
        /// Use a set of well defined configurations preset to support certain use cases. Can be overwritten with more specific values.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public H265V2PresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// Automatically configures the encoder for the given SDR/HDR format.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicRangeFormat")]
        public H265DynamicRangeFormat? DynamicRangeFormat { get; set; }

        /// <summary>
        /// Rate control mode configuration. Used to Configure the Perceptual Encoding Mode Settings.
        /// </summary>
        [JsonProperty(PropertyName = "rateControlModeConfig")]
        public H265V2RateControlModeConfig RateControlModeConfig { get; set; }

        /// <summary>
        /// Motion compensated temporal filtering mode.
        /// </summary>
        [JsonProperty(PropertyName = "motionCompensatedTemporalFiltering")]
        public H265V2MotionCompensatedTemporalFiltering? MotionCompensatedTemporalFiltering { get; set; }

        /// <summary>
        /// Set codec tier to high when true, main when false.
        /// </summary>
        [JsonProperty(PropertyName = "levelHighTier")]
        public bool? LevelHighTier { get; set; }
    }
}
