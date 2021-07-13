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
    /// DashImscRepresentation
    /// </summary>
    public class DashImscRepresentation : BitmovinResource
    {
        /// <summary>
        /// URL of the referenced IMSC file (required)
        /// </summary>
        [JsonProperty(PropertyName = "imscUrl")]
        public string ImscUrl { get; set; }
    }
}
