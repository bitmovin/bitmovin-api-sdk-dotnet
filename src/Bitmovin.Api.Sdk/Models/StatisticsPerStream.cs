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
        public string StreamId { get; set; }
        
        /// <summary>
        /// ID of the condec configuration (required)
        /// </summary>
        [JsonProperty(PropertyName = "codecConfigId")]
        public string CodecConfigId { get; set; }
        
        /// <summary>
        /// Multiplier for the encoded minutes. Depends on muxing type. (required)
        /// </summary>
        [JsonProperty(PropertyName = "multiplicator")]
        public double? Multiplicator { get; set; }
        
        /// <summary>
        /// Encoded bytes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodedBytes")]
        public long? EncodedBytes { get; set; }
        
        /// <summary>
        /// Length of the stream. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodedSeconds")]
        public double? EncodedSeconds { get; set; }
        
        /// <summary>
        /// Minutes you will be charged for (billableMinutes &#x3D; encodedSeconds * multiplicator) (required)
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; set; }
        
        /// <summary>
        /// Video width, only if video stream
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public long? Width { get; set; }
        
        /// <summary>
        /// Video height, only if video stream
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public long? Height { get; set; }
        
        /// <summary>
        /// If it&#39; a video stream this value is the FPS, for audio it&#39;s the sample rate. (required)
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }
        
        /// <summary>
        /// Bitrate of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; set; }
        
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
        public double? EncodingModeMultiplicator { get; set; }
        
        /// <summary>
        /// PerTitleResultStream
        /// </summary>
        [JsonProperty(PropertyName = "perTitleResultStream")]
        public StatisticsPerTitleStream? PerTitleResultStream { get; set; }
        
        /// <summary>
        /// The output minutes multiplicator for per-title
        /// </summary>
        [JsonProperty(PropertyName = "perTitleMultiplicator")]
        public double? PerTitleMultiplicator { get; set; }
        
        /// <summary>
        /// PsnrMode
        /// </summary>
        [JsonProperty(PropertyName = "psnrMode")]
        public PsnrPerStreamMode? PsnrMode { get; set; }
        
        /// <summary>
        /// The output minutes multiplicator for psnr streams
        /// </summary>
        [JsonProperty(PropertyName = "psnrMultiplicator")]
        public double? PsnrMultiplicator { get; set; }
        
        /// <summary>
        /// DolbyVisionMode
        /// </summary>
        [JsonProperty(PropertyName = "dolbyVisionMode")]
        public DolbyVisionPerStreamMode? DolbyVisionMode { get; set; }
        
        /// <summary>
        /// The output minutes multiplicator for Dolby Vision streams
        /// </summary>
        [JsonProperty(PropertyName = "dolbyVisionMultiplicator")]
        public double? DolbyVisionMultiplicator { get; set; }
    }

}
