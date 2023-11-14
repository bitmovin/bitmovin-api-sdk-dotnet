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
    /// StreamsVideoResponse
    /// </summary>
    public class StreamsVideoResponse
    {
        /// <summary>
        /// The identifier of the stream
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The asset URL of the stream
        /// </summary>
        [JsonProperty(PropertyName = "assetUrl")]
        public string AssetUrl { get; internal set; }

        /// <summary>
        /// The title of the stream
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; internal set; }

        /// <summary>
        /// The description of the stream
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; internal set; }

        /// <summary>
        /// Creation timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The status of the stream
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public StreamsVideoStatus? Status { get; internal set; }

        /// <summary>
        /// StyleConfig
        /// </summary>
        [JsonProperty(PropertyName = "styleConfig")]
        public StreamsStyleConfigResponse StyleConfig { get; set; }

        /// <summary>
        /// List of encoding status information
        /// </summary>
        [JsonProperty(PropertyName = "encodingTasks")]
        public List<StreamsVideoEncodingTask> EncodingTasks { get; internal set; } = new List<StreamsVideoEncodingTask>();

        /// <summary>
        /// Poster URL
        /// </summary>
        [JsonProperty(PropertyName = "posterUrl")]
        public string PosterUrl { get; internal set; }

        /// <summary>
        /// AdConfig
        /// </summary>
        [JsonProperty(PropertyName = "adConfig")]
        public StreamsAdConfigResponse AdConfig { get; set; }

        /// <summary>
        /// ContentProtection
        /// </summary>
        [JsonProperty(PropertyName = "contentProtection")]
        public StreamsContentProtectionResponse ContentProtection { get; set; }

        /// <summary>
        /// Stream trimming information
        /// </summary>
        [JsonProperty(PropertyName = "trimming")]
        public StreamsTrimmingStatus? Trimming { get; internal set; }

        /// <summary>
        /// Single-file download URL of the unaltered video in the best available quality
        /// </summary>
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; internal set; }

        /// <summary>
        /// True if the stream is signature protected
        /// </summary>
        [JsonProperty(PropertyName = "signed")]
        public bool? Signed { get; internal set; }
    }
}
