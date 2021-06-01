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
        /// The filename of your manifest. If this is not set, the &#x60;name&#x60; is used as output file name. Either one of &#x60;name&#x60; or &#x60;manifestName&#x60; is required. Be aware that spaces will be replaced with underlines (&#x60;_&#x60;) on the output.
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

        /// <summary>
        /// Controls the behaviour of the CHANNELS attribute for the EXT-X-VERSION tag
        /// </summary>
        [JsonProperty(PropertyName = "channelsAttributeForAudio")]
        public ChannelsAttributeForAudio? ChannelsAttributeForAudio { get; set; }

        /// <summary>
        /// The rounding applied to target duration. Two possible rouding modes exist: NORMAL_ROUNDING, when the target duration is rounded to the nearest integer, or UPWARDS_ROUNDING, when the target duration is rounded to the highest integer. 
        /// </summary>
        [JsonProperty(PropertyName = "targetDurationRoundingMode")]
        public HlsTargetDurationRoundingMode? TargetDurationRoundingMode { get; set; }
    }
}
