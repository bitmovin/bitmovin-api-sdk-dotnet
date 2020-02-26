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
    /// ResponseError
    /// </summary>
    public class ResponseError
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
        public ResponseErrorData Data { get; internal set; }
    }
}
