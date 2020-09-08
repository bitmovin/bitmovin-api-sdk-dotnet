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
        /// Version of the Player (required)
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; internal set; }

        /// <summary>
        /// URL of the specified player (required)
        /// </summary>
        [JsonProperty(PropertyName = "cdnUrl")]
        public string CdnUrl { get; internal set; }

        /// <summary>
        /// Download URL of the specified player package (required)
        /// </summary>
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; internal set; }

        /// <summary>
        /// Creation timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ (required)
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }
    }
}
