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
    /// StreamsLiveCreateRequest
    /// </summary>
    public class StreamsLiveCreateRequest
    {
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
        /// Id of the style config to use
        /// </summary>
        [JsonProperty(PropertyName = "styleConfigId")]
        public string StyleConfigId { get; set; }

        /// <summary>
        /// Id of the advertisement config to use
        /// </summary>
        [JsonProperty(PropertyName = "adConfigId")]
        public string AdConfigId { get; set; }
    }
}
