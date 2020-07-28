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
    /// H265VideoConfiguration
    /// </summary>
    public class H265VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "H265";

        /// <summary>
        /// Use a set of well defined configurations preset to support certain use cases. Can be overwritten with more specific values.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public PresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// Sets the constant rate factor for quality-based variable bitrate. Either bitrate or crf is required.
        /// </summary>
        [JsonProperty(PropertyName = "crf")]
        public double? Crf { get; set; }

        /// <summary>
        /// Profile
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public ProfileH265? Profile { get; set; }

        /// <summary>
        /// Sets the amount of b frames
        /// </summary>
        [JsonProperty(PropertyName = "bframes")]
        public int? Bframes { get; set; }

        /// <summary>
        /// Sets the amount of reference frames
        /// </summary>
        [JsonProperty(PropertyName = "refFrames")]
        public int? RefFrames { get; set; }

        /// <summary>
        /// Sets the quantization factor
        /// </summary>
        [JsonProperty(PropertyName = "qp")]
        public int? Qp { get; set; }

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
        /// Specify the size of the VBV buffer (kbits)
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
        /// Level
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public LevelH265? Level { get; set; }

        /// <summary>
        /// Number of frames for slice-type decision lookahead
        /// </summary>
        [JsonProperty(PropertyName = "rcLookahead")]
        public int? RcLookahead { get; set; }

        /// <summary>
        /// Set the level of effort in determining B frame placement
        /// </summary>
        [JsonProperty(PropertyName = "bAdapt")]
        public BAdapt? BAdapt { get; set; }

        /// <summary>
        /// MaxCTUSize
        /// </summary>
        [JsonProperty(PropertyName = "maxCTUSize")]
        public MaxCtuSize? MaxCTUSize { get; set; }

        /// <summary>
        /// TuIntraDepth
        /// </summary>
        [JsonProperty(PropertyName = "tuIntraDepth")]
        public TuIntraDepth? TuIntraDepth { get; set; }

        /// <summary>
        /// TuInterDepth
        /// </summary>
        [JsonProperty(PropertyName = "tuInterDepth")]
        public TuInterDepth? TuInterDepth { get; set; }

        /// <summary>
        /// MotionSearch
        /// </summary>
        [JsonProperty(PropertyName = "motionSearch")]
        public MotionSearch? MotionSearch { get; set; }

        /// <summary>
        /// Set the amount of subpel refinement to perform.
        /// </summary>
        [JsonProperty(PropertyName = "subMe")]
        public int? SubMe { get; set; }

        /// <summary>
        /// Set the Motion search range.
        /// </summary>
        [JsonProperty(PropertyName = "motionSearchRange")]
        public int? MotionSearchRange { get; set; }

        /// <summary>
        /// Enable weighted prediction in P slices
        /// </summary>
        [JsonProperty(PropertyName = "weightPredictionOnPSlice")]
        public bool? WeightPredictionOnPSlice { get; set; }

        /// <summary>
        /// Enable weighted prediction in B slices
        /// </summary>
        [JsonProperty(PropertyName = "weightPredictionOnBSlice")]
        public bool? WeightPredictionOnBSlice { get; set; }

        /// <summary>
        /// Toggle sample adaptive offset loop filter
        /// </summary>
        [JsonProperty(PropertyName = "sao")]
        public bool? Sao { get; set; }

        /// <summary>
        /// Set the mastering display color volume SEI info (SMPTE ST 2086). For example &#x60;G(13250,34500)B(7500,3000)R(34000,16000)WP(15635,16450)L(10000000,1)&#x60; describes a P3D65 1000-nits monitor, where G(x&#x3D;0.265, y&#x3D;0.690), B(x&#x3D;0.150, y&#x3D;0.060), R(x&#x3D;0.680, y&#x3D;0.320), WP(x&#x3D;0.3127, y&#x3D;0.3290), L(max&#x3D;1000, min&#x3D;0.0001). Part of HDR-10 metadata. If used on a Dolby Vision stream, this value must be set to &#x60;G(13250,34500)B(7500,3000)R(34000,16000)WP(15635,16450)L(10000000,1)&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "masterDisplay")]
        public string MasterDisplay { get; set; }

        /// <summary>
        /// Set the max content light level (MaxCLL). Use together with maxPictureAverageLightLevel (which will be 0 if not set). Part of HDR-10 metadata.
        /// </summary>
        [JsonProperty(PropertyName = "maxContentLightLevel")]
        public int? MaxContentLightLevel { get; set; }

        /// <summary>
        /// Set the maximum picture average light level (MaxFALL). Use together with maxContentLightLevel (which will be 0 if not set). Part of HDR-10 metadata.
        /// </summary>
        [JsonProperty(PropertyName = "maxPictureAverageLightLevel")]
        public int? MaxPictureAverageLightLevel { get; set; }

        /// <summary>
        /// Force signaling of HDR parameters in SEI packets. Enabled automatically when masterDisplay or maxContentLightLevel/maxPictureAverageLightLevel are set. Useful when there is a desire to signal 0 values for maxContentLightLevel and maxPictureAverageLightLevel.
        /// </summary>
        [JsonProperty(PropertyName = "hdr")]
        public bool? Hdr { get; set; }

        /// <summary>
        /// Scene Change sensitivity. The higher the value, the more likely an I-Frame will be inserted. Set to 0 to disable it.
        /// </summary>
        [JsonProperty(PropertyName = "sceneCutThreshold")]
        public int? SceneCutThreshold { get; set; }

        /// <summary>
        /// Controls the adaptive quantization algorithm
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveQuantizationMode")]
        public AdaptiveQuantMode? AdaptiveQuantizationMode { get; set; }

        /// <summary>
        /// By enabling this video stream will be signaled as HLG
        /// </summary>
        [JsonProperty(PropertyName = "enableHlgSignaling")]
        public bool? EnableHlgSignaling { get; set; }

        /// <summary>
        /// Specifies the source format of the original analog video prior to digitizing and encoding
        /// </summary>
        [JsonProperty(PropertyName = "videoFormat")]
        public VideoFormat? VideoFormat { get; set; }

        /// <summary>
        /// Psycho-visual rate-distortion retains fine details like film grain at the expense of more blocking artifacts. Higher values make the video appear sharper and more detailed but with a higher risk of blocking artifacts. Needs to have subMe with RD_IP, RD_ALL, RD_REF_IP, RD_REF_ALL, QPRD or FULL_RD
        /// </summary>
        [JsonProperty(PropertyName = "psyRateDistortionOptimization")]
        public double? PsyRateDistortionOptimization { get; set; }

        /// <summary>
        /// Strength of psycho-visual optimizations in quantization. Only has an effect in presets which use RDOQ (rd-levels 4 and 5). The value must be between 0 and 50, 1.0 is typical
        /// </summary>
        [JsonProperty(PropertyName = "psyRateDistortionOptimizedQuantization")]
        public double? PsyRateDistortionOptimizedQuantization { get; set; }

        /// <summary>
        /// Signal hypothetical reference decoder (HRD) information
        /// </summary>
        [JsonProperty(PropertyName = "enableHrdSignaling")]
        public bool? EnableHrdSignaling { get; set; }

        /// <summary>
        /// Enables the use of lookahead’s lowres motion vector fields to determine the amount of reuse of each block to tune adaptive quantization factors.
        /// </summary>
        [JsonProperty(PropertyName = "cutree")]
        public bool? Cutree { get; set; }

        /// <summary>
        /// Minimum CU size (width and height). By using 16 or 32 the encoder will not analyze the cost of CUs below that minimum threshold, saving considerable amounts of compute with a predictable increase in bitrate. This setting has a large effect on performance on the faster presets.
        /// </summary>
        [JsonProperty(PropertyName = "minCodingUnitSize")]
        public MinCodingUnitSize? MinCodingUnitSize { get; set; }

        /// <summary>
        /// Use multiple worker threads to measure the estimated cost of each frame within the lookahead. The higher this parameter, the less accurate the frame costs will be which will result in less accurate B-frame and scene-cut decisions. Valid range: 0 - 16
        /// </summary>
        [JsonProperty(PropertyName = "lookaheadSlices")]
        public int? LookaheadSlices { get; set; }

        /// <summary>
        /// If enabled, limit references per depth, CU or both.
        /// </summary>
        [JsonProperty(PropertyName = "limitReferences")]
        public LimitReferences? LimitReferences { get; set; }

        /// <summary>
        /// Enable analysis of rectangular motion partitions Nx2N and 2NxN.
        /// </summary>
        [JsonProperty(PropertyName = "rectangularMotionPartitionsAnalysis")]
        public bool? RectangularMotionPartitionsAnalysis { get; set; }

        /// <summary>
        /// Enable analysis of asymmetric motion partitions.
        /// </summary>
        [JsonProperty(PropertyName = "asymetricMotionPartitionsAnalysis")]
        public bool? AsymetricMotionPartitionsAnalysis { get; set; }

        /// <summary>
        /// When enabled, will limit modes analyzed for each CU using cost metrics from the 4 sub-CUs. This can significantly improve performance when &#x60;rectangularMotionPartitionsAnalysis&#x60; and/or &#x60;asymetricMotionPartitionsAnalysis&#x60; are enabled at minimal compression efficiency loss.
        /// </summary>
        [JsonProperty(PropertyName = "limitModes")]
        public bool? LimitModes { get; set; }

        /// <summary>
        /// Maximum number of neighbor (spatial and temporal) candidate blocks that the encoder may consider for merging motion predictions. Valid range: 1 - 5
        /// </summary>
        [JsonProperty(PropertyName = "maxMerge")]
        public int? MaxMerge { get; set; }

        /// <summary>
        /// Measure 2Nx2N merge candidates first; if no residual is found, additional modes at that depth are not analysed.
        /// </summary>
        [JsonProperty(PropertyName = "earlySkip")]
        public bool? EarlySkip { get; set; }

        /// <summary>
        /// If enabled exits early from CU depth recursion. When a skip CU is found, additional heuristics are used to decide whether to terminate recursion.
        /// </summary>
        [JsonProperty(PropertyName = "recursionSkip")]
        public bool? RecursionSkip { get; set; }

        /// <summary>
        /// Enable faster search method for angular intra predictions.
        /// </summary>
        [JsonProperty(PropertyName = "fastSearchForAngularIntraPredictions")]
        public bool? FastSearchForAngularIntraPredictions { get; set; }

        /// <summary>
        /// Enables the evaluation of intra modes in B slices.
        /// </summary>
        [JsonProperty(PropertyName = "evaluationOfIntraModesInBSlices")]
        public bool? EvaluationOfIntraModesInBSlices { get; set; }

        /// <summary>
        /// Hide sign bit of one coefficient per coding tree unit.
        /// </summary>
        [JsonProperty(PropertyName = "signHide")]
        public bool? SignHide { get; set; }

        /// <summary>
        /// Level of rate-distortion optimization in mode decision. The lower the value the faster the encode, the higher the value higher the compression efficiency. Valid range: 0 - 4
        /// </summary>
        [JsonProperty(PropertyName = "rateDistortionLevelForModeDecision")]
        public int? RateDistortionLevelForModeDecision { get; set; }

        /// <summary>
        /// Specify the amount of rate-distortion analysis to use within quantization.
        /// </summary>
        [JsonProperty(PropertyName = "rateDistortionLevelForQuantization")]
        public RateDistortionLevelForQuantization? RateDistortionLevelForQuantization { get; set; }

        /// <summary>
        /// Sets the minimum of quantization factor. Valid value range: 0 - 69
        /// </summary>
        [JsonProperty(PropertyName = "qpMin")]
        public int? QpMin { get; set; }

        /// <summary>
        /// Sets the maximum of quantization factor. Valid value range: 0 - 69
        /// </summary>
        [JsonProperty(PropertyName = "qpMax")]
        public int? QpMax { get; set; }

        /// <summary>
        /// The encoder may begin encoding a row as soon as the row above it is at least two CTUs ahead in the encode process. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "wavefrontParallelProcessing")]
        public bool? WavefrontParallelProcessing { get; set; }

        /// <summary>
        /// Encode each incoming frame as multiple parallel slices that may be decoded independently. Default is 1.
        /// </summary>
        [JsonProperty(PropertyName = "slices")]
        public int? Slices { get; set; }

        /// <summary>
        /// Copy buffers of input picture in frame. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "copyPicture")]
        public bool? CopyPicture { get; set; }

        /// <summary>
        /// If high tier is disabled the encoder will attempt to encode only at the main tier. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "levelHighTier")]
        public bool? LevelHighTier { get; set; }

        /// <summary>
        /// Enable skipping split rate distortion analysis when sum of split CU RD cost larger than one split CU RD cost for intra CU. Default disabled.
        /// </summary>
        [JsonProperty(PropertyName = "skipSplitRateDistortionAnalysis")]
        public bool? SkipSplitRateDistortionAnalysis { get; set; }

        /// <summary>
        /// If enabled, consider lossless mode in CU RDO decisions. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "codingUnitLossless")]
        public bool? CodingUnitLossless { get; set; }

        /// <summary>
        /// Enable evaluation of transform skip (bypass DCT but still use quantization) coding for 4x4 TU coded blocks. Default is NONE.
        /// </summary>
        [JsonProperty(PropertyName = "transformSkip")]
        public TransformSkipMode? TransformSkip { get; set; }

        /// <summary>
        /// Enable QP based rate distortion refinement. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "refineRateDistortionCost")]
        public bool? RefineRateDistortionCost { get; set; }

        /// <summary>
        /// Enables early exit from transform unit depth recursion, for inter coded blocks. Default is DISABLED.
        /// </summary>
        [JsonProperty(PropertyName = "limitTransformUnitDepthRecursion")]
        public LimitTransformUnitDepthRecursionMode? LimitTransformUnitDepthRecursion { get; set; }

        /// <summary>
        /// An integer value, which denotes strength of noise reduction in intra CUs. Default 0.
        /// </summary>
        [JsonProperty(PropertyName = "noiseReductionIntra")]
        public int? NoiseReductionIntra { get; set; }

        /// <summary>
        /// An integer value, which denotes strength of noise reduction in inter CUs. Default 0.
        /// </summary>
        [JsonProperty(PropertyName = "noiseReductionInter")]
        public int? NoiseReductionInter { get; set; }

        /// <summary>
        /// Penalty for 32x32 intra transform units in non-I slices. Default DISABLED.
        /// </summary>
        [JsonProperty(PropertyName = "rateDistortionPenalty")]
        public RateDistortionPenaltyMode? RateDistortionPenalty { get; set; }

        /// <summary>
        /// Penalty for 32x32 intra transform units in non-I slices. Default DISABLED.
        /// </summary>
        [JsonProperty(PropertyName = "maximumTransformUnitSize")]
        public MaxTransformUnitSize? MaximumTransformUnitSize { get; set; }

        /// <summary>
        /// Increases the RD level at points where quality drops due to VBV rate control enforcement. Default 0.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicRateDistortionStrength")]
        public int? DynamicRateDistortionStrength { get; set; }

        /// <summary>
        /// It is used for mode selection during analysis of CTUs and can achieve significant gain in terms of objective quality metrics SSIM and PSNR. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "ssimRateDistortionOptimization")]
        public bool? SsimRateDistortionOptimization { get; set; }

        /// <summary>
        /// Enable temporal motion vector predictors in P and B slices. Default true.
        /// </summary>
        [JsonProperty(PropertyName = "temporalMotionVectorPredictors")]
        public bool? TemporalMotionVectorPredictors { get; set; }

        /// <summary>
        /// Enable motion estimation with source frame pixels, in this mode, motion estimation can be computed independently. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "analyzeSourceFramePixels")]
        public bool? AnalyzeSourceFramePixels { get; set; }

        /// <summary>
        /// Enable strong intra smoothing for 32x32 intra blocks. Default true.
        /// </summary>
        [JsonProperty(PropertyName = "strongIntraSmoothing")]
        public bool? StrongIntraSmoothing { get; set; }

        /// <summary>
        /// When generating intra predictions for blocks in inter slices, only intra-coded reference pixels are used. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "constrainedIntraPrediction")]
        public bool? ConstrainedIntraPrediction { get; set; }

        /// <summary>
        /// This value represents the percentage difference between the inter cost and intra cost of a frame used in scenecut detection. Default 5.0.
        /// </summary>
        [JsonProperty(PropertyName = "scenecutBias")]
        public double? ScenecutBias { get; set; }

        /// <summary>
        /// Number of RADL pictures allowed infront of IDR. Requires fixed keyframe interval. Valid values 0 - &#x60;bframes&#x60;. Default 0.
        /// </summary>
        [JsonProperty(PropertyName = "allowedRADLBeforeIDR")]
        public int? AllowedRADLBeforeIDR { get; set; }

        /// <summary>
        /// Number of frames for GOP boundary decision lookahead. Valid values 0 - &#x60;rcLookahead&#x60;. Default 0
        /// </summary>
        [JsonProperty(PropertyName = "gopLookahead")]
        public int? GopLookahead { get; set; }

        /// <summary>
        /// Bias towards B frames in slicetype decision. The higher the bias the more likely the encoder is to use B frames. Default 0
        /// </summary>
        [JsonProperty(PropertyName = "bframeBias")]
        public int? BframeBias { get; set; }

        /// <summary>
        /// Force the encoder to flush frames. Default is DISABLED.
        /// </summary>
        [JsonProperty(PropertyName = "forceFlush")]
        public ForceFlushMode? ForceFlush { get; set; }

        /// <summary>
        /// Adjust the strength of the adaptive quantization offsets. Default 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveQuantizationStrength")]
        public double? AdaptiveQuantizationStrength { get; set; }

        /// <summary>
        /// Adjust the AQ offsets based on the relative motion of each block with respect to the motion of the frame. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveQuantizationMotion")]
        public bool? AdaptiveQuantizationMotion { get; set; }

        /// <summary>
        /// Enable adaptive quantization for sub-CTUs. This parameter specifies the minimum CU size at which QP can be adjusted. Default is same as &#x60;maxCTUSize&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "quantizationGroupSize")]
        public QuantizationGroupSize? QuantizationGroupSize { get; set; }

        /// <summary>
        /// Enables stricter conditions to control bitrate deviance from the target bitrate in ABR mode. Bit rate adherence is prioritised over quality. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "strictCbr")]
        public bool? StrictCbr { get; set; }

        /// <summary>
        /// Offset of Cb chroma QP from the luma QP selected by rate control. This is a general way to spend more or less bits on the chroma channel. Default 0
        /// </summary>
        [JsonProperty(PropertyName = "qpOffsetChromaCb")]
        public int? QpOffsetChromaCb { get; set; }

        /// <summary>
        /// Offset of Cr chroma QP from the luma QP selected by rate control. This is a general way to spend more or less bits on the chroma channel. Default 0
        /// </summary>
        [JsonProperty(PropertyName = "qpOffsetChromaCr")]
        public int? QpOffsetChromaCr { get; set; }

        /// <summary>
        /// QP ratio factor between I and P slices. This ratio is used in all of the rate control modes. Default 1.4
        /// </summary>
        [JsonProperty(PropertyName = "ipRatio")]
        public double? IpRatio { get; set; }

        /// <summary>
        /// QP ratio factor between P and B slices. This ratio is used in all of the rate control modes. Default 1.3
        /// </summary>
        [JsonProperty(PropertyName = "pbRatio")]
        public double? PbRatio { get; set; }

        /// <summary>
        /// Sets the quantizer curve compression factor. It weights the frame quantizer based on the complexity of residual (measured by lookahead). Default 0.6
        /// </summary>
        [JsonProperty(PropertyName = "quantizerCurveCompressionFactor")]
        public double? QuantizerCurveCompressionFactor { get; set; }

        /// <summary>
        /// The maximum single adjustment in QP allowed to rate control. Default 4
        /// </summary>
        [JsonProperty(PropertyName = "qpStep")]
        public int? QpStep { get; set; }

        /// <summary>
        /// Enables a specialised ratecontrol algorithm for film grain content. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "grainOptimizedRateControl")]
        public bool? GrainOptimizedRateControl { get; set; }

        /// <summary>
        /// Temporally blur quants. Default 0.5
        /// </summary>
        [JsonProperty(PropertyName = "blurQuants")]
        public double? BlurQuants { get; set; }

        /// <summary>
        /// Temporally blur complexity. Default 20.0
        /// </summary>
        [JsonProperty(PropertyName = "blurComplexity")]
        public double? BlurComplexity { get; set; }

        /// <summary>
        /// Specify how to handle depencency between SAO and deblocking filter. When enabled, non-deblocked pixels are used for SAO analysis. When disabled, SAO analysis skips the right/bottom boundary areas. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "saoNonDeblock")]
        public bool? SaoNonDeblock { get; set; }

        /// <summary>
        /// Limit SAO filter computation by early terminating SAO process based on inter prediction mode, CTU spatial-domain correlations, and relations between luma and chroma. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "limitSao")]
        public bool? LimitSao { get; set; }

        /// <summary>
        /// Will use low-pass subband dct approximation instead of the standard dct for 16x16 and 32x32 blocks. Default false.
        /// </summary>
        [JsonProperty(PropertyName = "lowpassDct")]
        public bool? LowpassDct { get; set; }

        /// <summary>
        /// Defines whether CEA 608/708 subtitles are extracted from the input video stream
        /// </summary>
        [JsonProperty(PropertyName = "cea608708SubtitleConfig")]
        public Cea608708SubtitleConfiguration Cea608708SubtitleConfig { get; set; }
    }
}
