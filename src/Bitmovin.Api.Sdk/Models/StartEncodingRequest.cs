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
    /// StartEncodingRequest
    /// </summary>
    public class StartEncodingRequest
    {
        /// <summary>
        /// Allows to encode only part of the input. Defines start (offset) and duration of the desired section. This is not allowed when the Encoding uses any kind of Input Stream resource.
        /// </summary>
        [JsonProperty(PropertyName = "trimming")]
        public Trimming Trimming { get; set; }

        /// <summary>
        /// Scheduling parameters of the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "scheduling")]
        public Scheduling Scheduling { get; set; }

        /// <summary>
        /// Special tweaks for your encoding job.
        /// </summary>
        [JsonProperty(PropertyName = "tweaks")]
        public Tweaks Tweaks { get; set; }

        /// <summary>
        /// Enable frame dropping/duplication to handle variable frames per seconds of video input streams
        /// </summary>
        [JsonProperty(PropertyName = "handleVariableInputFps")]
        public bool? HandleVariableInputFps { get; set; }

        /// <summary>
        /// The pass mode of the encoding. Must only be set when &#x60;encodingMode&#x60; is not set on any codec configuration used by this encoding.
        /// </summary>
        [JsonProperty(PropertyName = "encodingMode")]
        public EncodingMode? EncodingMode { get; set; }

        /// <summary>
        /// DASH manifests to be generated for previewing while the encoding is still running. See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "previewDashManifests")]
        public List<ManifestResource> PreviewDashManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// HLS manifests to be generated for previewing while the encoding is still running. See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "previewHlsManifests")]
        public List<ManifestResource> PreviewHlsManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// DASH manifests to be generated right after encoding (just-in-time). See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "vodDashManifests")]
        public List<ManifestResource> VodDashManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// HLS manifests to be generated right after encoding (just-in-time). See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "vodHlsManifests")]
        public List<ManifestResource> VodHlsManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// Smooth Streaming manifests to be generated right after encoding (just-in-time). See [documentation](https://developer.bitmovin.com/encoding/docs/how-to-create-manifests-for-your-encodings#just-in-time-jit)
        /// </summary>
        [JsonProperty(PropertyName = "vodSmoothManifests")]
        public List<ManifestResource> VodSmoothManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// Major version of the manifest generator to be used for manifests referenced in this request (by properties vodDashManifests, vodHlsManifests, vodSmoothManifests, previewDashManifests, previewHlsManifests). &#x60;V2&#x60; is available for encoder versions 2.70.0 and above and is the recommended option. The default value depends on the sign-up date of your organization. See [documentation](https://developer.bitmovin.com/encoding/docs/manifest-generator-v2) page for a detailed explanation. 
        /// </summary>
        [JsonProperty(PropertyName = "manifestGenerator")]
        public ManifestGenerator? ManifestGenerator { get; set; }

        /// <summary>
        /// Per-Title settings
        /// </summary>
        [JsonProperty(PropertyName = "perTitle")]
        public PerTitle PerTitle { get; set; }

        /// <summary>
        /// AI content analysis settings
        /// </summary>
        [JsonProperty(PropertyName = "aiContentAnalysis")]
        public AiContentAnalysis AiContentAnalysis { get; set; }
    }
}
