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
    /// InputTypeResponse
    /// </summary>
    public class InputTypeResponse
    {
        /// <summary>
        /// The type of the input
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public InputType? Type { get; set; }
    }
}
