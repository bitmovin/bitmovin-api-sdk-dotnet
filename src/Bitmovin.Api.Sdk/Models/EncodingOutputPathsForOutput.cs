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
    /// EncodingOutputPathsForOutput
    /// </summary>
    public class EncodingOutputPathsForOutput
    {
        /// <summary>
        /// Output paths for Dash manifests
        /// </summary>
        [JsonProperty(PropertyName = "dashManifests")]
        public List<EncodingOutputPathsDashManifest> DashManifests { get; set; } = new List<EncodingOutputPathsDashManifest>();

        /// <summary>
        /// Output paths for HLS manifests
        /// </summary>
        [JsonProperty(PropertyName = "hlsManifests")]
        public List<EncodingOutputPathsHlsManifest> HlsManifests { get; set; } = new List<EncodingOutputPathsHlsManifest>();

        /// <summary>
        /// Output paths for Smooth manifests
        /// </summary>
        [JsonProperty(PropertyName = "smoothManifests")]
        public List<EncodingOutputPathsSmoothManifest> SmoothManifests { get; set; } = new List<EncodingOutputPathsSmoothManifest>();
    }
}
