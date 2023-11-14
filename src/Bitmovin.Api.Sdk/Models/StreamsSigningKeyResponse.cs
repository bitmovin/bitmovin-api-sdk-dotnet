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
    /// StreamsSigningKeyResponse
    /// </summary>
    public class StreamsSigningKeyResponse
    {
        /// <summary>
        /// base64-encoded PEM file of the private key
        /// </summary>
        [JsonProperty(PropertyName = "privateKey")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// The unique identifier of the key
        /// </summary>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
