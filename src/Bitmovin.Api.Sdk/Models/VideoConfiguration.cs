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
    /// VideoConfiguration
    /// </summary>
    public class VideoConfiguration : CodecConfiguration
    {
        /// <summary>
        /// Width of the encoded video in pixels
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the encoded video in pixels
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Target bitrate for the encoded video in bps. Either bitrate or crf is required.
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; set; }

        /// <summary>
        /// Target frame rate of the encoded video. Must be set for live encodings
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Describes the color encoding, bit depth, and chroma subsampling of each pixel in the output image.
        /// </summary>
        [JsonProperty(PropertyName = "pixelFormat")]
        public PixelFormat? PixelFormat { get; set; }

        /// <summary>
        /// ColorConfig
        /// </summary>
        [JsonProperty(PropertyName = "colorConfig")]
        public ColorConfig ColorConfig { get; set; }

        /// <summary>
        /// The numerator of the sample aspect ratio (also known as pixel aspect ratio). Must be set if sampleAspectRatioDenominator is set. If set then displayAspectRatio is not allowed.
        /// </summary>
        [JsonProperty(PropertyName = "sampleAspectRatioNumerator")]
        public int? SampleAspectRatioNumerator { get; set; }

        /// <summary>
        /// The denominator of the sample aspect ratio (also known as pixel aspect ratio). Must be set if sampleAspectRatioNumerator is set. If set then displayAspectRatio is not allowed.
        /// </summary>
        [JsonProperty(PropertyName = "sampleAspectRatioDenominator")]
        public int? SampleAspectRatioDenominator { get; set; }

        /// <summary>
        /// Specifies a display aspect ratio (DAR) to be enforced. The sample aspect ratio (SAR) will be adjusted accordingly. If set then sampleAspectRatioNumerator and sampleAspectRatioDenominator are not allowed.
        /// </summary>
        [JsonProperty(PropertyName = "displayAspectRatio")]
        public DisplayAspectRatio DisplayAspectRatio { get; set; }

        /// <summary>
        /// The mode of the encoding. When this is set, &#x60;encodingMode&#x60; (&#x60;liveEncodingMode&#x60;) must not be set in the (live) encoding start request.
        /// </summary>
        [JsonProperty(PropertyName = "encodingMode")]
        public EncodingMode? EncodingMode { get; set; }
    }
}
