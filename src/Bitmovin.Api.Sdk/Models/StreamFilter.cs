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
    /// StreamFilter
    /// </summary>

    public class StreamFilter
    {
        /// <summary>
        /// The id of the filter that should be used in the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Defines the order in which filters are applied. Filters are applied in ascending order. (required)
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }
    }

}
