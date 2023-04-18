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
        /// Config
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public StreamsConfigResponse Config { get; set; }
    }
}