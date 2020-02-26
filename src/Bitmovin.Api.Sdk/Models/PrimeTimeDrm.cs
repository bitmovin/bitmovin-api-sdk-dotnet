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
    /// PrimeTimeDrm
    /// </summary>
    public class PrimeTimeDrm : Drm
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "PRIMETIME";

        /// <summary>
        /// 16 byte Encryption key, 32 hexadecimal characters (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// 16 byte Key id, 32 hexadecimal characters (required)
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Base 64 Encoded (required)
        /// </summary>
        [JsonProperty(PropertyName = "pssh")]
        public string Pssh { get; set; }
    }
}
