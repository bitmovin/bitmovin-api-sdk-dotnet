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
#pragma warning disable CS0414
        private readonly string _type = "CAPTION_CEA708";
#pragma warning restore CS0414

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
        /// The CEA-708 caption service to extract, as defined in ANSI/CTA-708-E. Service 1 is the primary caption service and is used when this value is not set. Which services a stream carries depends on the source, so check it before selecting anything other than service 1.
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public int? Channel { get; set; }
    }
}
