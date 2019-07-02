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
    /// OutputTypeResponse
    /// </summary>

    public class OutputTypeResponse
    {
        /// <summary>
        /// The type of the output
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public OutputType? Type { get; set; }
    }

}
