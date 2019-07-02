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
    /// HlsManifest
    /// </summary>

    public class HlsManifest : Manifest
    {
        /// <summary>
        /// The filename of your manifest (required)
        /// </summary>
        [JsonProperty(PropertyName = "manifestName")]
        public string ManifestName { get; set; }
        
        /// <summary>
        /// If this is set, the EXT-X-VERSION tags of the Media Playlists are set to the provided version
        /// </summary>
        [JsonProperty(PropertyName = "hlsMediaPlaylistVersion")]
        public HlsVersion? HlsMediaPlaylistVersion { get; set; }
        
        /// <summary>
        /// If this is set, the EXT-X-VERSION tag of the Master Playlist is set to the provided version
        /// </summary>
        [JsonProperty(PropertyName = "hlsMasterPlaylistVersion")]
        public HlsVersion? HlsMasterPlaylistVersion { get; set; }
    }

}
