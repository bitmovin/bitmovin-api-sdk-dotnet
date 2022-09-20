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
    /// BitmovinStreamResponse
    /// </summary>
    public class BitmovinStreamResponse
    {
        /// <summary>
        /// The identifier of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The asset URL of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "assetUrl")]
        public string AssetUrl { get; internal set; }

        /// <summary>
        /// The title of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; internal set; }

        /// <summary>
        /// The description of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; internal set; }

        /// <summary>
        /// Creation timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The status of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public BitmovinStreamStatus? Status { get; internal set; }

        /// <summary>
        /// The target quality of the Stream (OBSOLETE!)
        /// </summary>
        [JsonProperty(PropertyName = "targetQuality")]
        public BitmovinStreamQuality? TargetQuality { get; internal set; }

        /// <summary>
        /// List of available stream qualities (OBSOLETE!)
        /// </summary>
        [JsonProperty(PropertyName = "availableQualities")]
        public List<BitmovinStreamQuality> AvailableQualities { get; internal set; } = new List<BitmovinStreamQuality>();

        /// <summary>
        /// List of encoding status information
        /// </summary>
        [JsonProperty(PropertyName = "encodingTasks")]
        public List<BitmovinStreamEncodingTask> EncodingTasks { get; internal set; } = new List<BitmovinStreamEncodingTask>();
    }
}
