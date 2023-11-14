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
    /// StreamsPublicSigningKeyResponse
    /// </summary>
    public class StreamsPublicSigningKeyResponse
    {
        /// <summary>
        /// PublicKeys
        /// </summary>
        [JsonProperty(PropertyName = "publicKeys")]
        public List<StreamsPublicSigningKey> PublicKeys { get; set; } = new List<StreamsPublicSigningKey>();
    }
}
