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
    /// LocalOutput
    /// </summary>
    public class LocalOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "LOCAL";
#pragma warning restore CS0414

        /// <summary>
        /// Path to your local storage (required)
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
    }
}
