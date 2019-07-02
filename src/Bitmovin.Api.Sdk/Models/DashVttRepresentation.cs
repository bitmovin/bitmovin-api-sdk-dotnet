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
    /// DashVttRepresentation
    /// </summary>

    public class DashVttRepresentation : BitmovinResource
    {
        /// <summary>
        /// URL of the referenced VTT file (required)
        /// </summary>
        [JsonProperty(PropertyName = "vttUrl")]
        public string VttUrl { get; set; }
    }

}
