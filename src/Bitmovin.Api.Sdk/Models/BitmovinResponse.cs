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
    /// BitmovinResponse
    /// </summary>

    public class BitmovinResponse
    {
        /// <summary>
        /// Id of the resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }
    }

}
