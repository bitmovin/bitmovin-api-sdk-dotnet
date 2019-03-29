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
        /// <summary>
        /// Path to your local storage
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
    }

}
