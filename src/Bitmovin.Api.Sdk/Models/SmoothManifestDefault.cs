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
    /// SmoothManifestDefault
    /// </summary>
    public class SmoothManifestDefault : SmoothStreamingManifest
    {
        /// <summary>
        /// The id of the encoding to create a default manifest for (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// Currently not in use
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public SmoothManifestDefaultVersion? Version { get; set; }
    }
}
