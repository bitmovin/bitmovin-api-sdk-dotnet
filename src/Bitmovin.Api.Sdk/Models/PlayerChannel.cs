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
    /// PlayerChannel
    /// </summary>

    public class PlayerChannel : BitmovinResponse
    {
        /// <summary>
        /// Name of the resource (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; internal set; }
    }

}
