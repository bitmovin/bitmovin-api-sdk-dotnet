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
    /// ResourceLimitContainer
    /// </summary>

    public class ResourceLimitContainer
    {
        /// <summary>
        /// Resource
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public ResourceType? Resource { get; set; }
        
        /// <summary>
        /// Limits
        /// </summary>
        [JsonProperty(PropertyName = "limits")]
        public List<ResourceLimit> Limits { get; set; } = new List<ResourceLimit>();
    }

}
