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
    /// UpdateBitmovinStreamRequest
    /// </summary>
    public class UpdateBitmovinStreamRequest
    {
        /// <summary>
        /// The status of the Stream
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public BitmovinStreamStatus? Status { get; set; }

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
