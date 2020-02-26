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
    /// AkamaiNetStorageOutput
    /// </summary>
    public class AkamaiNetStorageOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AKAMAI_NETSTORAGE";

        /// <summary>
        /// Host to use for Akamai NetStorage transfers (required)
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Your Akamai NetStorage Username (required)
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Your Akamai NetStorage password (required)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}
