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
    /// Vp9VideoConfiguration
    /// </summary>
    public class Vp9VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "VP9";

        /// <summary>
        /// Choose from a set of preset configurations tailored for common use cases. Check out [VP9 Presets](https://bitmovin.com/docs/encoding/tutorials/vp9-presets) to see which values get applied by each preset. Explicitly setting a property to a different value will override the preset&#39;s value for that property.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public PresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// Sets the constant rate factor for quality-based variable bitrate. Either bitrate or crf is required.
        /// </summary>
        [JsonProperty(PropertyName = "crf")]
        public int? Crf { get; set; }

        /// <summary>
        /// Number of frames to look ahead for alternate reference frame selection.
        /// </summary>
        [JsonProperty(PropertyName = "lagInFrames")]
        public int? LagInFrames { get; set; }

        /// <summary>
        /// Enables error resiliency feature
        /// </summary>
        [JsonProperty(PropertyName = "errorResiliencyEnabled")]
        public bool? ErrorResiliencyEnabled { get; set; }

        /// <summary>
        /// Number of tile columns to use, log2. Depending on the encoding width there are limitations on this value. The minimum values are 2 for width &gt;&#x3D; 1920 and 1 for width &gt;&#x3D; 1280. The minimum width of each tile is 256 pixels so the maximum values are 0 for width &lt; 256, 1 for width &lt; 512, 2 for width &lt; 1024, 3 for width &lt; 2048, 4 for width &lt; 4096, 5 for width &lt; 8192. If the value is too high or too low it will be overridden.
        /// </summary>
        [JsonProperty(PropertyName = "tileColumns")]
        public int? TileColumns { get; set; }

        /// <summary>
        /// Number of tile rows to use, log2.
        /// </summary>
        [JsonProperty(PropertyName = "tileRows")]
        public int? TileRows { get; set; }

        /// <summary>
        /// Enable frame parallel decodability features
        /// </summary>
        [JsonProperty(PropertyName = "frameParallel")]
        public bool? FrameParallel { get; set; }

        /// <summary>
        /// Maximum I-frame bitrate (percentage) 0&#x3D;unlimited
        /// </summary>
        [JsonProperty(PropertyName = "maxIntraRate")]
        public long? MaxIntraRate { get; set; }

        /// <summary>
        /// Sets the minimum of quantization factor.
        /// </summary>
        [JsonProperty(PropertyName = "qpMin")]
        public int? QpMin { get; set; }

        /// <summary>
        /// Sets the maximum of quantization factor.
        /// </summary>
        [JsonProperty(PropertyName = "qpMax")]
        public int? QpMax { get; set; }

        /// <summary>
        /// Datarate undershoot (min) target (percentage).
        /// </summary>
        [JsonProperty(PropertyName = "rateUndershootPct")]
        public int? RateUndershootPct { get; set; }

        /// <summary>
        /// Datarate overshoot (max) target (percentage).
        /// </summary>
        [JsonProperty(PropertyName = "rateOvershootPct")]
        public int? RateOvershootPct { get; set; }

        /// <summary>
        /// Client buffer size (ms)
        /// </summary>
        [JsonProperty(PropertyName = "clientBufferSize")]
        public long? ClientBufferSize { get; set; }

        /// <summary>
        /// Client initial buffer size (ms)
        /// </summary>
        [JsonProperty(PropertyName = "clientInitialBufferSize")]
        public long? ClientInitialBufferSize { get; set; }

        /// <summary>
        /// CBR/VBR bias (0&#x3D;CBR, 100&#x3D;VBR)
        /// </summary>
        [JsonProperty(PropertyName = "biasPct")]
        public int? BiasPct { get; set; }

        /// <summary>
        /// Enable noise sensitivity on Y channel
        /// </summary>
        [JsonProperty(PropertyName = "noiseSensitivity")]
        public bool? NoiseSensitivity { get; set; }

        /// <summary>
        /// Controls the tradeoff between compression efficiency and encoding speed. Higher values indicate a faster encoding. The minimum value for width * height &gt;&#x3D; 1280 * 720 is 2. If the value is too low it will be overridden.
        /// </summary>
        [JsonProperty(PropertyName = "cpuUsed")]
        public int? CpuUsed { get; set; }

        /// <summary>
        /// Enable automatic alternate reference frames (2pass only)
        /// </summary>
        [JsonProperty(PropertyName = "automaticAltRefFramesEnabled")]
        public bool? AutomaticAltRefFramesEnabled { get; set; }

        /// <summary>
        /// Target level (255: off, 0: only keep level stats; 10: level 1.0; 11: level 1.1; ... 62: level 6.2)
        /// </summary>
        [JsonProperty(PropertyName = "targetLevel")]
        public int? TargetLevel { get; set; }

        /// <summary>
        /// Enable row based non-deterministic multi-threading
        /// </summary>
        [JsonProperty(PropertyName = "rowMultiThreadingEnabled")]
        public bool? RowMultiThreadingEnabled { get; set; }

        /// <summary>
        /// Loop filter sharpness.
        /// </summary>
        [JsonProperty(PropertyName = "sharpness")]
        public int? Sharpness { get; set; }

        /// <summary>
        /// Minimum GOP length, the minimum distance between I-frames.
        /// </summary>
        [JsonProperty(PropertyName = "minGop")]
        public int? MinGop { get; set; }

        /// <summary>
        /// Maximum GOP length, the maximum distance between I-frames
        /// </summary>
        [JsonProperty(PropertyName = "maxGop")]
        public int? MaxGop { get; set; }

        /// <summary>
        /// Minimum interval in seconds between key frames
        /// </summary>
        [JsonProperty(PropertyName = "minKeyframeInterval")]
        public double? MinKeyframeInterval { get; set; }

        /// <summary>
        /// Maximum interval in seconds between key frames
        /// </summary>
        [JsonProperty(PropertyName = "maxKeyframeInterval")]
        public double? MaxKeyframeInterval { get; set; }

        /// <summary>
        /// Quality
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public Vp9Quality? Quality { get; set; }

        /// <summary>
        /// Lossless mode
        /// </summary>
        [JsonProperty(PropertyName = "lossless")]
        public bool? Lossless { get; set; }

        /// <summary>
        /// A change threshold on blocks below which they will be skipped by the encoder.
        /// </summary>
        [JsonProperty(PropertyName = "staticThresh")]
        public int? StaticThresh { get; set; }

        /// <summary>
        /// AqMode
        /// </summary>
        [JsonProperty(PropertyName = "aqMode")]
        public Vp9AqMode? AqMode { get; set; }

        /// <summary>
        /// altref noise reduction max frame count.
        /// </summary>
        [JsonProperty(PropertyName = "arnrMaxFrames")]
        public int? ArnrMaxFrames { get; set; }

        /// <summary>
        /// altref noise reduction filter strength.
        /// </summary>
        [JsonProperty(PropertyName = "arnrStrength")]
        public int? ArnrStrength { get; set; }

        /// <summary>
        /// ArnrType
        /// </summary>
        [JsonProperty(PropertyName = "arnrType")]
        public Vp9ArnrType? ArnrType { get; set; }
    }
}
