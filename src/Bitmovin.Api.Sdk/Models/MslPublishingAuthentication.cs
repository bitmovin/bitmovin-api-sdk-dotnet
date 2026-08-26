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
    /// MSL5 publishing-side authentication. When enabled, the encoder sends HTTP Digest Authentication headers with every segment upload.  When &#x60;enabled&#x60; is &#x60;true&#x60;, &#x60;username&#x60; and &#x60;password&#x60; are required; the API rejects the request otherwise. When &#x60;enabled&#x60; is &#x60;false&#x60; (or this object is omitted), credentials are ignored. 
    /// </summary>
    public class MslPublishingAuthentication
    {
        /// <summary>
        /// Whether HTTP Digest publishing authentication is enabled. (required)
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// HTTP Digest username for publishing MSL5 segments. Required when &#x60;enabled&#x60; is &#x60;true&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// HTTP Digest password for publishing MSL5 segments. Required when &#x60;enabled&#x60; is &#x60;true&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}
