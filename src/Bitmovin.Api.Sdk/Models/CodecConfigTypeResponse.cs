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
    /// CodecConfigTypeResponse
    /// </summary>
    public class CodecConfigTypeResponse
    {
        /// <summary>
        /// The type of the codec config
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public CodecConfigType? Type { get; set; }
    }
}
