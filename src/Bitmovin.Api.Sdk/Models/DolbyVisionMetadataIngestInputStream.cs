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
    /// DolbyVisionMetadataIngestInputStream
    /// </summary>
    public class DolbyVisionMetadataIngestInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "SIDECAR_DOLBY_VISION_METADATA";
#pragma warning restore CS0414

        /// <summary>
        /// Id of input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to Dolby Vision Metadata file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }
    }
}
