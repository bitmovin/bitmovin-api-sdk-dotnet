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
    /// StreamsAdConfigResponse
    /// </summary>
    public class StreamsAdConfigResponse
    {
        /// <summary>
        /// The identifier of the streams ad config
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Ads
        /// </summary>
        [JsonProperty(PropertyName = "ads")]
        public List<StreamsAdConfigAd> Ads { get; set; } = new List<StreamsAdConfigAd>();
    }
}
