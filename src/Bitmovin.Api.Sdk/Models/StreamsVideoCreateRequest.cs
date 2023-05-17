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
    /// StreamsVideoCreateRequest
    /// </summary>
    public class StreamsVideoCreateRequest
    {
        /// <summary>
        /// The streams input asset URL
        /// </summary>
        [JsonProperty(PropertyName = "assetUrl")]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Title of the stream
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of the stream
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Id of the stream config to use
        /// </summary>
        [JsonProperty(PropertyName = "configId")]
        public string ConfigId { get; set; }

        /// <summary>
        /// Id of the advertisement config to use
        /// </summary>
        [JsonProperty(PropertyName = "adConfigId")]
        public string AdConfigId { get; set; }
    }
}
