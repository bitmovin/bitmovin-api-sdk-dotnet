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
    /// MuxingTypeResponse
    /// </summary>
    public class MuxingTypeResponse
    {
        /// <summary>
        /// The type of the Muxing
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public MuxingType? Type { get; set; }
    }
}
