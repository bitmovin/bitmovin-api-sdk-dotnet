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
    /// StatisticsPerStream
    /// </summary>
    public class StatisticsPerStream
    {
        /// <summary>
        /// ID of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; internal set; }

        /// <summary>
        /// ID of the condec configuration (required)
        /// </summary>
        [JsonProperty(PropertyName = "codecConfigId")]
        public string CodecConfigId { get; internal set; }

        /// <summary>
        /// Multiplier for the encoded minutes. Depends on muxing type. (required)
        /// </summary>
        [JsonProperty(PropertyName = "multiplicator")]
        public double? Multiplicator { get; internal set; }

        /// <summary>
        /// Encoded bytes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodedBytes")]
        public long? EncodedBytes { get; internal set; }

        /// <summary>
        /// Length of the stream. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodedSeconds")]
        public double? EncodedSeconds { get; internal set; }

        /// <summary>
        /// Minutes you will be charged for (billableMinutes &#x3D; encodedSeconds * multiplicator) (required)
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; internal set; }

        /// <summary>
        /// Video width, only if video stream
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public long? Width { get; internal set; }

        /// <summary>
        /// Video height, only if video stream
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public long? Height { get; internal set; }

        /// <summary>
        /// If it&#39; a video stream this value is the FPS, for audio it&#39;s the sample rate. (required)
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; internal set; }

        /// <summary>
        /// Bitrate of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; internal set; }

        /// <summary>
        /// Codec
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public CodecConfigType? Codec { get; set; }

        /// <summary>
        /// Resolution
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public StatisticsResolution? Resolution { get; set; }

        /// <summary>
        /// EncodingMode
        /// </summary>
        [JsonProperty(PropertyName = "encodingMode")]
        public EncodingMode? EncodingMode { get; set; }

        /// <summary>
        /// The output minutes multiplicator for the given encodingMode
        /// </summary>
        [JsonProperty(PropertyName = "encodingModeMultiplicator")]
        public double? EncodingModeMultiplicator { get; internal set; }

        /// <summary>
        /// PerTitleResultStream
        /// </summary>
        [JsonProperty(PropertyName = "perTitleResultStream")]
        public StatisticsPerTitleStream? PerTitleResultStream { get; set; }

        /// <summary>
        /// The output minutes multiplicator for per-title
        /// </summary>
        [JsonProperty(PropertyName = "perTitleMultiplicator")]
        public double? PerTitleMultiplicator { get; internal set; }

        /// <summary>
        /// PsnrMode
        /// </summary>
        [JsonProperty(PropertyName = "psnrMode")]
        public PsnrPerStreamMode? PsnrMode { get; set; }

        /// <summary>
        /// The output minutes multiplicator for psnr streams
        /// </summary>
        [JsonProperty(PropertyName = "psnrMultiplicator")]
        public double? PsnrMultiplicator { get; internal set; }

        /// <summary>
        /// DolbyVisionMode
        /// </summary>
        [JsonProperty(PropertyName = "dolbyVisionMode")]
        public DolbyVisionPerStreamMode? DolbyVisionMode { get; set; }

        /// <summary>
        /// The output minutes multiplicator for Dolby Vision streams
        /// </summary>
        [JsonProperty(PropertyName = "dolbyVisionMultiplicator")]
        public double? DolbyVisionMultiplicator { get; internal set; }

        /// <summary>
        /// Name of the preset configuration used for the codec configuration or \&quot;CUSTOM\&quot; if any preset values were overridden
        /// </summary>
        [JsonProperty(PropertyName = "preset")]
        public string Preset { get; internal set; }

        /// <summary>
        /// The output minutes multiplicator for the used codec configuration preset.
        /// </summary>
        [JsonProperty(PropertyName = "presetMultiplicator")]
        public double? PresetMultiplicator { get; internal set; }

        /// <summary>
        /// Indicates if the stream was part of a live encoding.
        /// </summary>
        [JsonProperty(PropertyName = "live")]
        public bool? Live { get; internal set; }

        /// <summary>
        /// The output minutes multiplicator for live streams.
        /// </summary>
        [JsonProperty(PropertyName = "liveMultiplicator")]
        public double? LiveMultiplicator { get; internal set; }

        /// <summary>
        /// Indicates if an enhanced interlace filter was used.
        /// </summary>
        [JsonProperty(PropertyName = "enhancedDeinterlace")]
        public bool? EnhancedDeinterlace { get; internal set; }

        /// <summary>
        /// The output minutes multiplicator for streams using an enhanced deinterlace filter.
        /// </summary>
        [JsonProperty(PropertyName = "enhancedDeinterlaceMultiplicator")]
        public double? EnhancedDeinterlaceMultiplicator { get; internal set; }

        /// <summary>
        /// NexGuardABWatermarkingType
        /// </summary>
        [JsonProperty(PropertyName = "nexGuardABWatermarkingType")]
        public NexGuardABWatermarkingFeature? NexGuardABWatermarkingType { get; set; }

        /// <summary>
        /// The output minutes multiplicator for streams using a NexGuard A/B Watermarking.
        /// </summary>
        [JsonProperty(PropertyName = "nexGuardABWatermarkingMultiplicator")]
        public double? NexGuardABWatermarkingMultiplicator { get; internal set; }

        /// <summary>
        /// InputFactor
        /// </summary>
        [JsonProperty(PropertyName = "inputFactor")]
        public InputFactor InputFactor { get; set; }
    }
}
