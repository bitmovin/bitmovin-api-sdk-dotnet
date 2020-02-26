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
    /// Av1VideoConfiguration
    /// </summary>
    public class Av1VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AV1";

        /// <summary>
        /// KeyPlacementMode
        /// </summary>
        [JsonProperty(PropertyName = "keyPlacementMode")]
        public Av1KeyPlacementMode? KeyPlacementMode { get; set; }

        /// <summary>
        /// AdaptiveQuantMode
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveQuantMode")]
        public Av1AdaptiveQuantMode? AdaptiveQuantMode { get; set; }

        /// <summary>
        /// Number of frames to look ahead for alternate reference frame selection
        /// </summary>
        [JsonProperty(PropertyName = "lagInFrames")]
        public int? LagInFrames { get; set; }

        /// <summary>
        /// Minimum (best quality) quantizer
        /// </summary>
        [JsonProperty(PropertyName = "minQ")]
        public int? MinQ { get; set; }

        /// <summary>
        /// Maximum (worst quality) quantizer
        /// </summary>
        [JsonProperty(PropertyName = "maxQ")]
        public int? MaxQ { get; set; }

        /// <summary>
        /// Rate control adaptation undershoot control
        /// </summary>
        [JsonProperty(PropertyName = "undershootPct")]
        public int? UndershootPct { get; set; }

        /// <summary>
        /// Rate control adaptation overshoot control
        /// </summary>
        [JsonProperty(PropertyName = "overshootPct")]
        public int? OvershootPct { get; set; }

        /// <summary>
        /// Decoder buffer size in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "clientBufferSize")]
        public long? ClientBufferSize { get; set; }

        /// <summary>
        /// Decoder buffer initial size in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "clientInitialBufferSize")]
        public long? ClientInitialBufferSize { get; set; }

        /// <summary>
        /// Decoder buffer optimal size in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "clientOptimalBufferSize")]
        public long? ClientOptimalBufferSize { get; set; }

        /// <summary>
        /// Number of tile columns to use, log2
        /// </summary>
        [JsonProperty(PropertyName = "tileColumns")]
        public int? TileColumns { get; set; }

        /// <summary>
        /// Number of tile rows to use, log2
        /// </summary>
        [JsonProperty(PropertyName = "tileRows")]
        public int? TileRows { get; set; }

        /// <summary>
        /// Enable automatic set and use alf frames
        /// </summary>
        [JsonProperty(PropertyName = "isAutomaticAltRefFramesEnabled")]
        public bool? IsAutomaticAltRefFramesEnabled { get; set; }

        /// <summary>
        /// The max number of frames to create arf
        /// </summary>
        [JsonProperty(PropertyName = "arnrMaxFrames")]
        public int? ArnrMaxFrames { get; set; }

        /// <summary>
        /// The filter strength for the arf
        /// </summary>
        [JsonProperty(PropertyName = "arnrStrength")]
        public int? ArnrStrength { get; set; }

        /// <summary>
        /// Maximum data rate for intra frames, expressed as a percentage of the average per-frame bitrate. Default value 0 meaning unlimited
        /// </summary>
        [JsonProperty(PropertyName = "maxIntraRate")]
        public long? MaxIntraRate { get; set; }

        /// <summary>
        /// Lossless encoding mode
        /// </summary>
        [JsonProperty(PropertyName = "isLossless")]
        public bool? IsLossless { get; set; }

        /// <summary>
        /// Enable frame parallel decoding feature
        /// </summary>
        [JsonProperty(PropertyName = "isFrameParallel")]
        public bool? IsFrameParallel { get; set; }

        /// <summary>
        /// Sets the sharpness
        /// </summary>
        [JsonProperty(PropertyName = "sharpness")]
        public int? Sharpness { get; set; }

        /// <summary>
        /// Enable quality boost by lowering frame level Q periodically
        /// </summary>
        [JsonProperty(PropertyName = "isFrameBoostEnabled")]
        public bool? IsFrameBoostEnabled { get; set; }

        /// <summary>
        /// Enable noise sensitivity on Y channel
        /// </summary>
        [JsonProperty(PropertyName = "noiseSensitivity")]
        public bool? NoiseSensitivity { get; set; }

        /// <summary>
        /// Minimum interval between GF/ARF frames
        /// </summary>
        [JsonProperty(PropertyName = "minGfInterval")]
        public int? MinGfInterval { get; set; }

        /// <summary>
        /// Maximum interval between GF/ARF frames
        /// </summary>
        [JsonProperty(PropertyName = "maxGfInterval")]
        public int? MaxGfInterval { get; set; }

        /// <summary>
        /// Maximum number of tile groups
        /// </summary>
        [JsonProperty(PropertyName = "numTileGroups")]
        public int? NumTileGroups { get; set; }

        /// <summary>
        /// Maximum number of bytes in a tile group
        /// </summary>
        [JsonProperty(PropertyName = "mtuSize")]
        public int? MtuSize { get; set; }
    }
}
