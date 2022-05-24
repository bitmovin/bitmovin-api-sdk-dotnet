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
    /// EncodingOutputPathsSmoothManifest
    /// </summary>
    public class EncodingOutputPathsSmoothManifest
    {
        /// <summary>
        /// Id of the Smooth manifest
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Path to the client manifest of the Smooth manifest on the given output
        /// </summary>
        [JsonProperty(PropertyName = "clientManifestPath")]
        public string ClientManifestPath { get; set; }

        /// <summary>
        /// Path to the server manifest of the Smooth manifest on the given output
        /// </summary>
        [JsonProperty(PropertyName = "serverManifestPath")]
        public string ServerManifestPath { get; set; }
    }
}
