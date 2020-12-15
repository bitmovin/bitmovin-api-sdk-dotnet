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
    /// PaginationResponse
    /// </summary>
    public class PaginationResponse<T>
    {
        /// <summary>
        /// TotalCount
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public long? TotalCount { get; internal set; }

        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; internal set; }

        /// <summary>
        /// Limit
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; internal set; }

        /// <summary>
        /// Previous
        /// </summary>
        [JsonProperty(PropertyName = "previous")]
        public string Previous { get; internal set; }

        /// <summary>
        /// Next
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; internal set; }

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public List<T> Items { get; internal set; } = new List<T>();
    }
}
