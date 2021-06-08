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
    /// Scte35Cue
    /// </summary>
    public class Scte35Cue : BitmovinResponse
    {
        /// <summary>
        /// Cue out duration in seconds. (required)
        /// </summary>
        [JsonProperty(PropertyName = "cueDuration")]
        public double? CueDuration { get; set; }

        /// <summary>
        /// The ids of the manifests to update. If this property is not set, all the manifests tied to the encoding are updated.
        /// </summary>
        [JsonProperty(PropertyName = "manifestIds")]
        public List<string> ManifestIds { get; set; } = new List<string>();
    }
}
