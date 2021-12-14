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
    /// AdaptationSetTypeResponse
    /// </summary>
    public class AdaptationSetTypeResponse
    {
        /// <summary>
        /// The type of the adaptation set
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AdaptationSetType? Type { get; set; }
    }
}
