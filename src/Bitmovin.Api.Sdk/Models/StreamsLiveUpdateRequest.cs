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
    /// StreamsLiveUpdateRequest
    /// </summary>
    public class StreamsLiveUpdateRequest
    {
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
        /// URL to hosted poster image
        /// </summary>
        [JsonProperty(PropertyName = "posterUrl")]
        public string PosterUrl { get; set; }

        /// <summary>
        /// Id of the domain restriction config to use
        /// </summary>
        [JsonProperty(PropertyName = "domainRestrictionId")]
        public string DomainRestrictionId { get; set; }
    }
}
