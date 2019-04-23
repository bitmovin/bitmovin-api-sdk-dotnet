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
    /// DashCmafDrmRepresentation
    /// </summary>

    public class DashCmafDrmRepresentation : DashCmafRepresentation
    {
        /// <summary>
        /// DRM Id
        /// </summary>
        [JsonProperty(PropertyName = "drmId")]
        public string DrmId { get; set; }
    }

}
