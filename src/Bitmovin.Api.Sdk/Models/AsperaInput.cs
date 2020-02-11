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
    /// AsperaInput
    /// </summary>

    public class AsperaInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "ASPERA";

        /// <summary>
        /// Minimal download bandwidth. Examples: 100k, 100m, 100g
        /// </summary>
        [JsonProperty(PropertyName = "minBandwidth")]
        public string MinBandwidth { get; set; }
        
        /// <summary>
        /// Maximal download bandwidth. Examples: 100k, 100m, 100g
        /// </summary>
        [JsonProperty(PropertyName = "maxBandwidth")]
        public string MaxBandwidth { get; set; }
        
        /// <summary>
        /// Host to use for Aspera transfers (required)
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Username to log into Aspera host (either password and user must be set or token)
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <summary>
        /// corresponding password (either password and user must be set or token)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Token used for authentication (either password and user must be set or token)
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        
        /// <summary>
        /// Set the TCP port to be used for fasp session initiation
        /// </summary>
        [JsonProperty(PropertyName = "sshPort")]
        public int? SshPort { get; set; }
        
        /// <summary>
        /// Set the UDP port to be used by fasp for data transfer
        /// </summary>
        [JsonProperty(PropertyName = "faspPort")]
        public int? FaspPort { get; set; }
    }

}
