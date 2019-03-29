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
    /// PlayerVersion
    /// </summary>

    public class PlayerVersion : BitmovinResponse
    {
        /// <summary>
        /// Version of the Player
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; internal set; }
        
        /// <summary>
        /// URL of the specified player
        /// </summary>
        [JsonProperty(PropertyName = "cdnUrl")]
        public string CdnUrl { get; internal set; }
        
        /// <summary>
        /// Download URL of the specified player package
        /// </summary>
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; internal set; }
        
        /// <summary>
        /// Creation timestamp expressed in UTC: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }
    }

}
