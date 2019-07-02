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
    /// ManifestTypeResponse
    /// </summary>

    public class ManifestTypeResponse
    {
        /// <summary>
        /// The type of the manifest
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ManifestType? Type { get; set; }
    }

}
