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
    /// CustomWebPlayerBuildDomain
    /// </summary>

    public class CustomWebPlayerBuildDomain : BitmovinResource
    {
        /// <summary>
        /// Domain where the player is allowed to play (required)
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
    }

}
