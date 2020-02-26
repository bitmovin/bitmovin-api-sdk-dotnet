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
    /// AccountApiKey
    /// </summary>
    public class AccountApiKey : BitmovinResource
    {
        /// <summary>
        /// Key value for authentication with the Bitmovin API (required)
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
