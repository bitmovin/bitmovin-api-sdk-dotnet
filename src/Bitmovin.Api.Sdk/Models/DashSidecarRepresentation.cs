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
    /// DashSidecarRepresentation
    /// </summary>

    public class DashSidecarRepresentation : DashRepresentation
    {
        /// <summary>
        /// Sidecar Id
        /// </summary>
        [JsonProperty(PropertyName = "sidecarId")]
        public string SidecarId { get; set; }
    }

}
