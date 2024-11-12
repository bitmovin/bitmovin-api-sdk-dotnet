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
    /// AkamaiAccount
    /// </summary>
    public class AkamaiAccount : BitmovinResource
    {
        /// <summary>
        /// Akamai/Linode API token (required)
        /// </summary>
        [JsonProperty(PropertyName = "apiToken")]
        public string ApiToken { get; set; }
    }
}
