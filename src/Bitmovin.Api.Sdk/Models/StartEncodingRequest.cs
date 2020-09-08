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
        /// Allows to encode only part of the input. Defines start (offset) and duration of the desired section.
        /// </summary>
        [JsonProperty(PropertyName = "trimming")]
        public Trimming Trimming { get; set; }

        /// <summary>
        /// Set scheduling parameters of the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "scheduling")]
        public Scheduling Scheduling { get; set; }

        /// <summary>
        /// Set special tweaks for your encoding job.
        /// </summary>
        [JsonProperty(PropertyName = "tweaks")]
        public Tweaks Tweaks { get; set; }

        /// <summary>
        /// Enable frame dropping/duplication to handle variable frames per seconds of video input streams
        /// </summary>
        [JsonProperty(PropertyName = "handleVariableInputFps")]
        public bool? HandleVariableInputFps { get; set; }

        /// <summary>
        /// The pass mode of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "encodingMode")]
        public EncodingMode? EncodingMode { get; set; }

        /// <summary>
        /// List of preview DASH manifests to be created
        /// </summary>
        [JsonProperty(PropertyName = "previewDashManifests")]
        public List<ManifestResource> PreviewDashManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// List of preview HLS manifests to be created
        /// </summary>
        [JsonProperty(PropertyName = "previewHlsManifests")]
        public List<ManifestResource> PreviewHlsManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// List of VoD DASH manifests to be created after encoding finished successfully
        /// </summary>
        [JsonProperty(PropertyName = "vodDashManifests")]
        public List<ManifestResource> VodDashManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// List of VoD HLS manifests to be created after encoding finished successfully
        /// </summary>
        [JsonProperty(PropertyName = "vodHlsManifests")]
        public List<ManifestResource> VodHlsManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// List of VoD SMOOTH manifests to be created after encoding finished successfully
        /// </summary>
        [JsonProperty(PropertyName = "vodSmoothManifests")]
        public List<ManifestResource> VodSmoothManifests { get; set; } = new List<ManifestResource>();

        /// <summary>
        /// Per-Title settings
        /// </summary>
        [JsonProperty(PropertyName = "perTitle")]
        public PerTitle PerTitle { get; set; }
    }
}
