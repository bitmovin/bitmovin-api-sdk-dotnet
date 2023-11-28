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
    /// TenantWithGroups
    /// </summary>
    public class TenantWithGroups
    {
        /// <summary>
        /// Id of Tenant (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Email of Tenant (required)
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// List of all groups of Tenant (required)
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public List<TenantGroupDetail> Groups { get; set; } = new List<TenantGroupDetail>();
    }
}
