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
    /// OrganizationPendingInvitation
    /// </summary>
    public class OrganizationPendingInvitation
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
        /// Id of group (required)
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Name of group (required)
        /// </summary>
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
    }
}
