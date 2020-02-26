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
    /// Cea708CaptionInputStream
    /// </summary>
    public class Cea708CaptionInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "CAPTION_CEA708";

        /// <summary>
        /// Id of the Input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to media file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }

        /// <summary>
        /// The channel number of the subtitle on the respective stream position. Must not be smaller than 1 (required)
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public int? Channel { get; set; }
    }
}
