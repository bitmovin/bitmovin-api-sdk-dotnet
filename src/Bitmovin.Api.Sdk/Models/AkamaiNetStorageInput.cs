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
    /// AkamaiNetStorageInput
    /// </summary>

    public class AkamaiNetStorageInput : Input
    {
        /// <summary>
        /// Host to use for Akamai NetStorage transfers
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Your Akamai NetStorage Username
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <summary>
        /// Your Akamai NetStorage password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }

}
