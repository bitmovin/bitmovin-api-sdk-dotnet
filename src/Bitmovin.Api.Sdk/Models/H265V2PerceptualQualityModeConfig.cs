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
    /// H265V2PerceptualQualityModeConfig
    /// </summary>
    public class H265V2PerceptualQualityModeConfig : H265V2RateControlModeConfig
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "PERCEPTUAL_QUALITY_MODE";
#pragma warning restore CS0414

        /// <summary>
        /// HVS-based perceptual encoding mode (0:off 1:cudqp 2:+quant).
        /// </summary>
        [JsonProperty(PropertyName = "percept")]
        public int? Percept { get; set; }

        /// <summary>
        /// Overall strength of perceptual model (0.0-1.0).
        /// </summary>
        [JsonProperty(PropertyName = "percStr")]
        public double? PercStr { get; set; }

        /// <summary>
        /// Strength of penalties from perceptual model (0.0-1.0).
        /// </summary>
        [JsonProperty(PropertyName = "percPenaltyStr")]
        public double? PercPenaltyStr { get; set; }

        /// <summary>
        /// Knee point of penalty strength modulation (0.0-1.0).
        /// </summary>
        [JsonProperty(PropertyName = "percPenaltyKnee")]
        public double? PercPenaltyKnee { get; set; }

        /// <summary>
        /// Strength of temporal component of perceptual model (0.0-1.0).
        /// </summary>
        [JsonProperty(PropertyName = "percTemporalStr")]
        public double? PercTemporalStr { get; set; }

        /// <summary>
        /// Pixels per degree (horizontal), i.e. width / FOV.
        /// </summary>
        [JsonProperty(PropertyName = "pixelPerDegree")]
        public double? PixelPerDegree { get; set; }
    }
}
