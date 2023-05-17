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
    /// H264VideoConfiguration
    /// </summary>
    public class H264VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "H264";

        /// <summary>
        /// Choose from a set of preset configurations tailored for common use cases. Check out [H264 Presets](https://bitmovin.com/docs/encoding/tutorials/h264-presets) to see which values get applied by each preset. Explicitly setting a property to a different value will override the preset&#39;s value for that property.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public PresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// Automatically configures the H264 Video Codec to be compatible with the given SDR format. Bitmovin recommends to use the dynamic range format together with a preset configuration to achieve good results. Explicitly configured properties will take precedence over dynamic range format settings, which in turn will take precedence over preset configurations.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicRangeFormat")]
        public H264DynamicRangeFormat? DynamicRangeFormat { get; set; }

        /// <summary>
        /// Constant rate factor for quality-based variable bitrate. Either bitrate or crf is required.
        /// </summary>
        [JsonProperty(PropertyName = "crf")]
        public double? Crf { get; set; }

        /// <summary>
        /// When setting a profile, all other settings must not exceed the limits which are defined in the profile. Otherwise, a higher profile may be automatically chosen. (required)
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public ProfileH264? Profile { get; set; }

        /// <summary>
        /// Amount of b frames
        /// </summary>
        [JsonProperty(PropertyName = "bframes")]
        public int? Bframes { get; set; }

        /// <summary>
        /// Amount of reference frames.
        /// </summary>
        [JsonProperty(PropertyName = "refFrames")]
        public int? RefFrames { get; set; }

        /// <summary>
        /// Minimum quantization factor
        /// </summary>
        [JsonProperty(PropertyName = "qpMin")]
        public int? QpMin { get; set; }

        /// <summary>
        /// Maximum quantization factor
        /// </summary>
        [JsonProperty(PropertyName = "qpMax")]
        public int? QpMax { get; set; }

        /// <summary>
        /// MvPredictionMode
        /// </summary>
        [JsonProperty(PropertyName = "mvPredictionMode")]
        public MvPredictionMode? MvPredictionMode { get; set; }

        /// <summary>
        /// Maximum motion vector search range
        /// </summary>
        [JsonProperty(PropertyName = "mvSearchRangeMax")]
        public int? MvSearchRangeMax { get; set; }

        /// <summary>
        /// Enable or disable CABAC
        /// </summary>
        [JsonProperty(PropertyName = "cabac")]
        public bool? Cabac { get; set; }

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
        [JsonProperty(PropertyName = "minGop")]
        public int? MinGop { get; set; }

        /// <summary>
        /// Maximum GOP length, the maximum distance between I-frames
        /// </summary>
        [JsonProperty(PropertyName = "maxGop")]
        public int? MaxGop { get; set; }

        /// <summary>
        /// Enable open-gop, allows referencing frames from a previous gop
        /// </summary>
        [JsonProperty(PropertyName = "openGop")]
        public bool? OpenGop { get; set; }

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
        /// If three-pass encoding is used and a level is set for the encoder, the bitrate for some segments may exceed the bitrate limit which is defined by the level.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public LevelH264? Level { get; set; }

        /// <summary>
        /// BAdaptiveStrategy
        /// </summary>
        [JsonProperty(PropertyName = "bAdaptiveStrategy")]
        public BAdapt? BAdaptiveStrategy { get; set; }

        /// <summary>
        /// MotionEstimationMethod
        /// </summary>
        [JsonProperty(PropertyName = "motionEstimationMethod")]
        public H264MotionEstimationMethod? MotionEstimationMethod { get; set; }

        /// <summary>
        /// Number of frames for frame-type decision lookahead
        /// </summary>
        [JsonProperty(PropertyName = "rcLookahead")]
        public int? RcLookahead { get; set; }

        /// <summary>
        /// Subpixel motion estimation and mode decision
        /// </summary>
        [JsonProperty(PropertyName = "subMe")]
        public H264SubMe? SubMe { get; set; }

        /// <summary>
        /// Enables or disables Trellis quantization. NOTE: This requires cabac
        /// </summary>
        [JsonProperty(PropertyName = "trellis")]
        public H264Trellis? Trellis { get; set; }

        /// <summary>
        /// Partitions to consider. Analyzing more partition options improves quality at the cost of speed.
        /// </summary>
        [JsonProperty(PropertyName = "partitions")]
        public List<H264Partition> Partitions { get; set; } = new List<H264Partition>();

        /// <summary>
        /// Number of slices per frame.
        /// </summary>
        [JsonProperty(PropertyName = "slices")]
        public int? Slices { get; set; }

        /// <summary>
        /// Using TOP_FIELD_FIRST or BOTTOM_FIELD_FIRST will output interlaced video
        /// </summary>
        [JsonProperty(PropertyName = "interlaceMode")]
        public H264InterlaceMode? InterlaceMode { get; set; }

        /// <summary>
        /// Scene change sensitivity. The higher the value, the more likely an I-frame will be inserted. Set to 0 to disable it which is advised for scenarios where fixed GOP is required, e.g., adaptive streaming outputs like DASH, HLS and Smooth. Having this setting enabled can improve quality for progressive output with an increased internal chunk length (see &#x60;internalChunkLength&#x60; of muxings).
        /// </summary>
        [JsonProperty(PropertyName = "sceneCutThreshold")]
        public int? SceneCutThreshold { get; set; }

        /// <summary>
        /// Signal hypothetical reference decoder (HRD) information (requires bufsize to be set)
        /// </summary>
        [JsonProperty(PropertyName = "nalHrd")]
        public H264NalHrd? NalHrd { get; set; }

        /// <summary>
        /// Keep some B-frames as references
        /// </summary>
        [JsonProperty(PropertyName = "bPyramid")]
        public H264BPyramid? BPyramid { get; set; }

        /// <summary>
        /// Defines whether CEA 608/708 subtitles are copied from the input video stream
        /// </summary>
        [JsonProperty(PropertyName = "cea608708SubtitleConfig")]
        public Cea608708SubtitleConfiguration Cea608708SubtitleConfig { get; set; }

        /// <summary>
        /// Strength of the in-loop deblocking filter. Higher values deblock more effectively but also soften the image
        /// </summary>
        [JsonProperty(PropertyName = "deblockAlpha")]
        public int? DeblockAlpha { get; set; }

        /// <summary>
        /// Threshold of the in-loop deblocking filter. Higher values apply deblocking stronger on non flat blocks, lower values on flat blocks
        /// </summary>
        [JsonProperty(PropertyName = "deblockBeta")]
        public int? DeblockBeta { get; set; }

        /// <summary>
        /// Controls the adaptive quantization algorithm
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveQuantizationMode")]
        public AdaptiveQuantMode? AdaptiveQuantizationMode { get; set; }

        /// <summary>
        /// Values greater than 1 reduce blocking and blurring in flat and textured areas. Values less than 1 reduces ringing artifacts at the cost of more banding artifacts. Negative values are not allowed
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveQuantizationStrength")]
        public double? AdaptiveQuantizationStrength { get; set; }

        /// <summary>
        /// Allow references on a per partition basis, rather than per-macroblock basis
        /// </summary>
        [JsonProperty(PropertyName = "mixedReferences")]
        public bool? MixedReferences { get; set; }

        /// <summary>
        /// Enables adaptive spatial transform (high profile 8x8 transform)
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveSpatialTransform")]
        public bool? AdaptiveSpatialTransform { get; set; }

        /// <summary>
        /// Enables fast skip detection on P-frames. Disabling this very slightly increases quality but at a large speed loss
        /// </summary>
        [JsonProperty(PropertyName = "fastSkipDetectionPFrames")]
        public bool? FastSkipDetectionPFrames { get; set; }

        /// <summary>
        /// Enable open-gop, allows referencing frames from a previous gop
        /// </summary>
        [JsonProperty(PropertyName = "weightedPredictionBFrames")]
        public bool? WeightedPredictionBFrames { get; set; }

        /// <summary>
        /// Defines the mode for weighted prediction for P-frames
        /// </summary>
        [JsonProperty(PropertyName = "weightedPredictionPFrames")]
        public WeightedPredictionPFrames? WeightedPredictionPFrames { get; set; }

        /// <summary>
        /// Enable macroblock tree ratecontrol. Macroblock tree rate control tracks how often blocks of the frame are used for prediciting future frames
        /// </summary>
        [JsonProperty(PropertyName = "macroblockTreeRatecontrol")]
        public bool? MacroblockTreeRatecontrol { get; set; }

        /// <summary>
        /// Ratio between constant bitrate (0.0) and constant quantizer (1.0). Valid range 0.0 - 1.0
        /// </summary>
        [JsonProperty(PropertyName = "quantizerCurveCompression")]
        public double? QuantizerCurveCompression { get; set; }

        /// <summary>
        /// Psychovisual Rate Distortion retains fine details like film grain at the expense of more blocking artifacts. Higher values make the video appear sharper and more detailed but with a higher risk of blocking artifacts. Needs to have subMe with RD_IP, RD_ALL, RD_REF_IP or RD_REF_ALL
        /// </summary>
        [JsonProperty(PropertyName = "psyRateDistortionOptimization")]
        public double? PsyRateDistortionOptimization { get; set; }

        /// <summary>
        /// Higher values will improve sharpness and detail retention but might come at costs of artifacts. Needs to have trellis enabled
        /// </summary>
        [JsonProperty(PropertyName = "psyTrellis")]
        public double? PsyTrellis { get; set; }

        /// <summary>
        /// Enable/disable automatic calculation of level, maxBitrate, and bufsize based on the least level that satisfies maximum property values for picture resolution, frame rate, and bit rate. In the case the target level is set explicitly, the maximum bitrate and buffer size are calculated based on the defined level. Explicitly setting maxBitrate, or bufsize properties will disable the automatic calculation.
        /// </summary>
        [JsonProperty(PropertyName = "autoLevelSetup")]
        public AutoLevelSetup? AutoLevelSetup { get; set; }
    }
}
