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
    /// DolbyVisionInputStream
    /// </summary>
    public class DolbyVisionInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DOLBY_VISION";

        /// <summary>
        /// Id of input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to Dolby Vision input video file. (required)
        /// </summary>
        [JsonProperty(PropertyName = "videoInputPath")]
        public string VideoInputPath { get; set; }

        /// <summary>
        /// Path to Dolby Vision Metadata file. This field is required when the metadata is not embedded in the video input file.
        /// </summary>
        [JsonProperty(PropertyName = "metadataInputPath")]
        public string MetadataInputPath { get; set; }
    }
}
