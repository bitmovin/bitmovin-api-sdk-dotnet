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
        /// PixelFormat
        /// </summary>
        [JsonProperty(PropertyName = "pixelFormat")]
        public PixelFormat PixelFormat { get; set; }
        
        /// <summary>
        /// ColorConfig
        /// </summary>
        [JsonProperty(PropertyName = "colorConfig")]
        public ColorConfig ColorConfig { get; set; }
        
        /// <summary>
        /// The numerator of the sample aspect ratio (also known as pixel aspect ratio). Must be set if sampleAspectRatioDenominator is set.
        /// </summary>
        [JsonProperty(PropertyName = "sampleAspectRatioNumerator")]
        public int? SampleAspectRatioNumerator { get; set; }
        
        /// <summary>
        /// The denominator of the sample aspect ratio (also known as pixel aspect ratio). Must be set if sampleAspectRatioNumerator is set.
        /// </summary>
        [JsonProperty(PropertyName = "sampleAspectRatioDenominator")]
        public int? SampleAspectRatioDenominator { get; set; }
        
        /// <summary>
        /// The mode of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "encodingMode")]
        public EncodingMode EncodingMode { get; set; }
    }

}
