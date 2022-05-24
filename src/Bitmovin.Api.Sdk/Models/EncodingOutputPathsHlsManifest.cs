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
    /// EncodingOutputPathsHlsManifest
    /// </summary>
    public class EncodingOutputPathsHlsManifest
    {
        /// <summary>
        /// Id of the HLS manifest
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Path to the index file of the HLS manifest on the given output
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
    }
}
