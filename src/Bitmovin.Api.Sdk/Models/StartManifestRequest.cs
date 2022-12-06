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
    /// StartManifestRequest
    /// </summary>
    public class StartManifestRequest
    {
        /// <summary>
        /// Version of the manifest generation engine to be used. The &#x60;V2&#x60; option is currently only supported for manifests including resources from a single encoding and is only valid in combination with encoder versions &gt;&#x3D;  &#x60;2.108.0&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "manifestGenerator")]
        public ManifestGenerator? ManifestGenerator { get; set; }
    }
}
