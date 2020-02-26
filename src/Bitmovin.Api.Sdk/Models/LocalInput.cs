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
    /// LocalInput
    /// </summary>
    public class LocalInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "LOCAL";

        /// <summary>
        /// Path to your local storage (required)
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
    }
}
