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
        /// <summary>
        /// Use a set of well defined configurations preset to support certain use cases. Can be overwritten with more specific values.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public PresetConfiguration PresetConfiguration { get; set; }
        
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
        /// Number of tile columns to use, log2.
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
        /// Enable noise sensitivity on Y channel
        /// </summary>
        [JsonProperty(PropertyName = "noiseSensitivity")]
        public bool? NoiseSensitivity { get; set; }
        
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
        public Vp9Quality Quality { get; set; }
        
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
        public Vp9AqMode AqMode { get; set; }
        
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
        public Vp9ArnrType ArnrType { get; set; }
    }

}
