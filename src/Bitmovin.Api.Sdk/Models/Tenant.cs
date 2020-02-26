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
    /// Tenant
    /// </summary>
    public class Tenant : BitmovinResource
    {
        /// <summary>
        /// Email address of the tenant. (required)
        /// </summary>
        [JsonProperty(PropertyName = "eMail")]
        public string EMail { get; set; }
    }
}
