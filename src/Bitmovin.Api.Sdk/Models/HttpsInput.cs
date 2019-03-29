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
    /// HttpsInput
    /// </summary>

    public class HttpsInput : Input
    {
        /// <summary>
        /// Host Url or IP of the HTTP server
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Basic Auth Username, if required
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <summary>
        /// Basic Auth Password, if required
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Custom Port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }

}
