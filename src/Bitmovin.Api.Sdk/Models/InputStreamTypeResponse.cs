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
    /// InputStreamTypeResponse
    /// </summary>

    public class InputStreamTypeResponse
    {
        /// <summary>
        /// The type of the input stream
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public InputStreamType? Type { get; set; }
    }

}
