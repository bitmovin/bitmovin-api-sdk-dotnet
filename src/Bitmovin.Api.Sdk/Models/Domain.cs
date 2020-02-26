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
    /// Domain
    /// </summary>
    public class Domain : BitmovinResource
    {
        /// <summary>
        /// Host where the player is allowed to play (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
