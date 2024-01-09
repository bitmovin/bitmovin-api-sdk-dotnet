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
    public class StreamsLiveResponse : StreamsResponse
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "LIVE";

        /// <summary>
        /// The streamKey of the stream
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; internal set; }

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
