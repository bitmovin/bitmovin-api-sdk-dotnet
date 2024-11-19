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
    /// LiveStandbyPoolRequest
    /// </summary>
    public class LiveStandbyPoolRequest : BitmovinResource
    {
        /// <summary>
        /// Number of instances to keep ready for streaming while the pool is running (required)
        /// </summary>
        [JsonProperty(PropertyName = "targetPoolSize")]
        public int? TargetPoolSize { get; set; }

        /// <summary>
        /// Base64 encoded template used to start the encodings in the pool (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingTemplate")]
        public string EncodingTemplate { get; set; }
    }
}
