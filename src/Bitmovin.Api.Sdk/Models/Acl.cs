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
    /// Acl
    /// </summary>
    public class Acl : BitmovinResource
    {
        /// <summary>
        /// Resource to define the permission for. (required)
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Policy
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public Policy? Policy { get; set; }

        /// <summary>
        /// Permissions to assign. (required)
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public List<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
