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
    /// ApiKey
    /// </summary>

    public class ApiKey : BitmovinResponse
    {
        /// <summary>
        /// KeyValue
        /// </summary>
        [JsonProperty(PropertyName = "keyValue")]
        public string KeyValue { get; set; }
    }

}
