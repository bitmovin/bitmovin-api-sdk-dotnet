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
    /// StreamsVideoUpdateRequest
    /// </summary>
    public class StreamsVideoUpdateRequest
    {
        /// <summary>
        /// The new status of the stream
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public StreamsVideoStatus? Status { get; set; }

        /// <summary>
        /// The new title of the stream
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The new description of the stream
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Id of the stream config to use
        /// </summary>
        [JsonProperty(PropertyName = "configId")]
        public string ConfigId { get; set; }

        /// <summary>
        /// URL to hosted poster image
        /// </summary>
        [JsonProperty(PropertyName = "posterUrl")]
        public string PosterUrl { get; set; }

        /// <summary>
        /// Id of the advertisement config to use
        /// </summary>
        [JsonProperty(PropertyName = "adConfigId")]
        public string AdConfigId { get; set; }

        /// <summary>
        /// Id of the content protection config to use
        /// </summary>
        [JsonProperty(PropertyName = "contentProtectionId")]
        public string ContentProtectionId { get; set; }
    }
}
