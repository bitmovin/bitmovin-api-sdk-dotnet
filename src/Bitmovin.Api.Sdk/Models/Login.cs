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
    /// Login
    /// </summary>

    public class Login
    {
        /// <summary>
        /// Email address of the account. (required)
        /// </summary>
        [JsonProperty(PropertyName = "eMail")]
        public string EMail { get; set; }
        
        /// <summary>
        /// Password of the account. (required)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }

}
