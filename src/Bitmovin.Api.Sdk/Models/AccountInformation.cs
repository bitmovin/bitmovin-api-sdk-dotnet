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

        /// <summary>
        /// IntercomIdVerification
        /// </summary>
        [JsonProperty(PropertyName = "intercomIdVerification")]
        public string IntercomIdVerification { get; internal set; }

        /// <summary>
        /// The Saml Domain of this Account
        /// </summary>
        [JsonProperty(PropertyName = "samlDomain")]
        public string SamlDomain { get; internal set; }

        /// <summary>
        /// Whether the user has accepted the Terms of Service. Users created via SAML SSO start as &#x60;false&#x60; because the SAML flow bypasses the registration form that normally captures TOS acceptance; all other signup paths default to &#x60;true&#x60;. Acceptance is one-way: sending &#x60;true&#x60; accepts the TOS, sending &#x60;false&#x60; is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "tosAccepted")]
        public bool? TosAccepted { get; set; }
    }
}
