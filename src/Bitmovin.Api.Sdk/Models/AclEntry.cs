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
    /// AclEntry
    /// </summary>
    public class AclEntry
    {
        /// <summary>
        /// Deprecation notice: The value of this property is not being used. It can be chosen arbitrarily or not set at all
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Permission
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public AclPermission? Permission { get; set; }
    }
}
