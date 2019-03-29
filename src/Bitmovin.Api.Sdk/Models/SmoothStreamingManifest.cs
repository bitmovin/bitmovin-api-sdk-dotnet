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
    /// SmoothStreamingManifest
    /// </summary>

    public class SmoothStreamingManifest : Manifest
    {
        /// <summary>
        /// Filename of the server manifest
        /// </summary>
        [JsonProperty(PropertyName = "serverManifestName")]
        public string ServerManifestName { get; set; }
        
        /// <summary>
        /// Filename of the client manifest
        /// </summary>
        [JsonProperty(PropertyName = "clientManifestName")]
        public string ClientManifestName { get; set; }
    }

}
