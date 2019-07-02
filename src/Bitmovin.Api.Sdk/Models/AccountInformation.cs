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
        public string Email { get; set; }
        
        /// <summary>
        /// ApiKeys associated with the account (required)
        /// </summary>
        [JsonProperty(PropertyName = "apiKeys")]
        public List<AccountApiKey> ApiKeys { get; set; } = new List<AccountApiKey>();
        
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
    }

}
