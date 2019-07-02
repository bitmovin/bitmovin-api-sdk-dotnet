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
    /// StartLiveEncodingRequest
    /// </summary>

    public class StartLiveEncodingRequest
    {
        /// <summary>
        /// Key for the stream. (a-zA-Z, 3-20 characters) (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; set; }
        
        /// <summary>
        /// List of Hls manifests to use for this live encoding
        /// </summary>
        [JsonProperty(PropertyName = "hlsManifests")]
        public List<LiveHlsManifest> HlsManifests { get; set; } = new List<LiveHlsManifest>();
        
        /// <summary>
        /// List of Dash manifests to use for this live encoding
        /// </summary>
        [JsonProperty(PropertyName = "dashManifests")]
        public List<LiveDashManifest> DashManifests { get; set; } = new List<LiveDashManifest>();
        
        /// <summary>
        /// The pass mode of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "liveEncodingMode")]
        public EncodingMode? LiveEncodingMode { get; set; }
        
        /// <summary>
        /// Reupload specific files during a live encoding. This can be helpful if an automatic life cycle policy is enabled on the output storage
        /// </summary>
        [JsonProperty(PropertyName = "reuploadSettings")]
        public ReuploadSettings ReuploadSettings { get; set; }
        
        /// <summary>
        /// Configuration for auto restarting the live encoding
        /// </summary>
        [JsonProperty(PropertyName = "autoRestartConfiguration")]
        public AutoRestartConfiguration AutoRestartConfiguration { get; set; }
    }

}
