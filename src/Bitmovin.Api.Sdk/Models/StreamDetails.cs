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
    /// StreamDetails
    /// </summary>
    public class StreamDetails
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Codec
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }
    }
}
