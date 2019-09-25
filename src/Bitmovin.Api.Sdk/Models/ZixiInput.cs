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
    /// ZixiInput
    /// </summary>

    public class ZixiInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "ZIXI";

        /// <summary>
        /// Host
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        
        /// <summary>
        /// Stream
        /// </summary>
        [JsonProperty(PropertyName = "stream")]
        public string Stream { get; set; }
        
        /// <summary>
        /// Password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Latency
        /// </summary>
        [JsonProperty(PropertyName = "latency")]
        public int? Latency { get; set; }
        
        /// <summary>
        /// MinBitrate
        /// </summary>
        [JsonProperty(PropertyName = "minBitrate")]
        public int? MinBitrate { get; set; }
        
        /// <summary>
        /// DecryptionType
        /// </summary>
        [JsonProperty(PropertyName = "decryptionType")]
        public string DecryptionType { get; set; }
        
        /// <summary>
        /// DecryptionKey
        /// </summary>
        [JsonProperty(PropertyName = "decryptionKey")]
        public string DecryptionKey { get; set; }
    }

}
