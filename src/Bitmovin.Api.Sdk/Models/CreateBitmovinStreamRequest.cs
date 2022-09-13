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
    /// CreateBitmovinStreamRequest
    /// </summary>
    public class CreateBitmovinStreamRequest
    {
        /// <summary>
        /// The Streams input asset URL
        /// </summary>
        [JsonProperty(PropertyName = "assetUrl")]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Title of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
