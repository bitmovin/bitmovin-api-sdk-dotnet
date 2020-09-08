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
    /// EncodingStreamInput
    /// </summary>
    public class EncodingStreamInput
    {
        /// <summary>
        /// Input id (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; internal set; }

        /// <summary>
        /// Path to media file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; internal set; }

        /// <summary>
        /// Details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public EncodingStreamInputDetails Details { get; set; }
    }
}
