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
        /// HLS manifests to be generated during the encoding. See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "hlsManifests")]
        public List<LiveHlsManifest> HlsManifests { get; set; } = new List<LiveHlsManifest>();

        /// <summary>
        /// DASH manifests to be generated during the encoding. See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "dashManifests")]
        public List<LiveDashManifest> DashManifests { get; set; } = new List<LiveDashManifest>();

        /// <summary>
        /// The pass mode of the encoding. Must only be set when &#x60;encodingMode&#x60; is not set on any codec configuration used by this encoding.
        /// </summary>
        [JsonProperty(PropertyName = "liveEncodingMode")]
        public EncodingMode? LiveEncodingMode { get; set; }

        /// <summary>
        /// Reupload specific files during a live encoding. This can be helpful if an automatic life cycle policy is enabled on the output storage
        /// </summary>
        [JsonProperty(PropertyName = "reuploadSettings")]
        public ReuploadSettings ReuploadSettings { get; set; }

        /// <summary>
        /// Major version of the manifest generator to be used for manifests referenced in this request (by properties dashManifests, dashManifests). &#x60;V2&#x60; is available for encoder versions 2.70.0 and above and is the recommended option. The default value depends on the sign-up date of your organization. See [documentation](https://developer.bitmovin.com/encoding/docs/manifest-generator-v2) page for a detailed explanation. 
        /// </summary>
        [JsonProperty(PropertyName = "manifestGenerator")]
        public ManifestGenerator? ManifestGenerator { get; set; }

        /// <summary>
        /// Configuration for auto restarting the live encoding
        /// </summary>
        [JsonProperty(PropertyName = "autoRestartConfiguration")]
        public AutoRestartConfiguration AutoRestartConfiguration { get; set; }

        /// <summary>
        /// Configuration for auto shutdown of the live encoding
        /// </summary>
        [JsonProperty(PropertyName = "autoShutdownConfiguration")]
        public LiveAutoShutdownConfiguration AutoShutdownConfiguration { get; set; }
    }
}
