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
    /// ResponseEnvelope
    /// </summary>
    public class ResponseEnvelope<T>
    {
        /// <summary>
        /// Unique correlation id (required)
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; internal set; }

        /// <summary>
        /// Response status information (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ResponseStatus? Status { get; internal set; }

        /// <summary>
        /// Response information (required)
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public ResultWrapper<T> Data { get; internal set; }

        /// <summary>
        /// Additional endpoint specific information
        /// </summary>
        [JsonProperty(PropertyName = "more")]
        public Object More { get; set; }
    }
}
