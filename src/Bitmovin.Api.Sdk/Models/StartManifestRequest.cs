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
        /// Major version of the manifest generator to be used. &#x60;V2&#x60; is the recommended option and requires the following minimum encoder versions: 2.121.0 for DASH, 2.111.0 for HLS, 2.108.0 for SMOOTH. The default value depends on the sign-up date of your organization. 
        /// </summary>
        [JsonProperty(PropertyName = "manifestGenerator")]
        public ManifestGenerator? ManifestGenerator { get; set; }
    }
}
