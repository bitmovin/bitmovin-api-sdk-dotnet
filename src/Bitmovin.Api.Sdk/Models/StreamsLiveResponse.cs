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
    /// StreamsLiveResponse
    /// </summary>
    public class StreamsLiveResponse
    {
        /// <summary>
        /// The identifier of the stream
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The streamKey of the stream
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; internal set; }

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
        /// The life cycle of the stream
        /// </summary>
        [JsonProperty(PropertyName = "lifeCycle")]
        public StreamsLiveLifeCycle? LifeCycle { get; internal set; }

        /// <summary>
        /// StyleConfig
        /// </summary>
        [JsonProperty(PropertyName = "styleConfig")]
        public StreamsStyleConfigResponse StyleConfig { get; set; }

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
    }
}
