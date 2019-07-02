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
    /// CustomPlayerBuildDetails
    /// </summary>

    public class CustomPlayerBuildDetails : BitmovinResource
    {
        /// <summary>
        /// The player version that should be used for the custom player build. If not set the &#39;latest&#39; version is used. (required)
        /// </summary>
        [JsonProperty(PropertyName = "playerVersion")]
        public string PlayerVersion { get; set; }
        
        /// <summary>
        /// The domains that the player is locked to. If not set the player will only work with &#39;localhost&#39;. Not more than 49 additional domains can be added. (required)
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public List<string> Domains { get; set; } = new List<string>();
    }

}
