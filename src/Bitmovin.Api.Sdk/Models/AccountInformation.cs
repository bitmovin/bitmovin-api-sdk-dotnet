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
    /// AccountInformation
    /// </summary>
    public class AccountInformation : BitmovinResource
    {
        /// <summary>
        /// Email address of the account. (required)
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; internal set; }

        /// <summary>
        /// ApiKeys associated with the account (required)
        /// </summary>
        [JsonProperty(PropertyName = "apiKeys")]
        public List<AccountApiKey> ApiKeys { get; internal set; } = new List<AccountApiKey>();

        /// <summary>
        /// First name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Phone number of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Company name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        /// <summary>
        /// Verified
        /// </summary>
        [JsonProperty(PropertyName = "verified")]
        public bool? Verified { get; internal set; }

        /// <summary>
        /// Marketplace
        /// </summary>
        [JsonProperty(PropertyName = "marketplace")]
        public Marketplace? Marketplace { get; internal set; }

        /// <summary>
        /// MfaEnabled
        /// </summary>
        [JsonProperty(PropertyName = "mfaEnabled")]
        public bool? MfaEnabled { get; internal set; }
    }
}
