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
    /// InputPath
    /// </summary>
    public class InputPath
    {
        /// <summary>
        /// Id of input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to media file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string _InputPath { get; set; }
    }
}
