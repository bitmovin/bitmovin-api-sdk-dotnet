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
    /// Vp8VideoConfiguration
    /// </summary>

    public class Vp8VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "VP8";

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
        /// CpuUsed
        /// </summary>
        [JsonProperty(PropertyName = "cpuUsed")]
        public int? CpuUsed { get; internal set; }
        
        /// <summary>
        /// NoiseSensitivity
        /// </summary>
        [JsonProperty(PropertyName = "noiseSensitivity")]
        public Vp8NoiseSensitivity? NoiseSensitivity { get; set; }
        
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
        public Vp8Quality? Quality { get; set; }
        
        /// <summary>
        /// A change threshold on blocks below which they will be skipped by the encoder.
        /// </summary>
        [JsonProperty(PropertyName = "staticThresh")]
        public int? StaticThresh { get; set; }
        
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
        public Vp8ArnrType? ArnrType { get; set; }
    }

}
