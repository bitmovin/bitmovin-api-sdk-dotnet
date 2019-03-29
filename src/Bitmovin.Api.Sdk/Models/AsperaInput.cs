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
        /// Host to use for Aspera transfers
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
    }

}
