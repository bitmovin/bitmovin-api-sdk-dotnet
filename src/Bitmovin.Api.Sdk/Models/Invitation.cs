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
    /// Invitation
    /// </summary>
    public class Invitation
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Email address of the tenant. (required)
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InvitationStatus? Status { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Creation date of the invitation in UTC format
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// JobTitle
        /// </summary>
        [JsonProperty(PropertyName = "jobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
    }
}
