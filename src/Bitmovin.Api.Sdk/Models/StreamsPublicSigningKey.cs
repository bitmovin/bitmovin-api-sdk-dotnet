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
    /// StreamsPublicSigningKey
    /// </summary>
    public class StreamsPublicSigningKey
    {
        /// <summary>
        /// The unique identifier of the key
        /// </summary>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }
    }
}
