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
    /// DvbSubtitleInputStream
    /// </summary>
    public class DvbSubtitleInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DVB_SUBTITLE";

        /// <summary>
        /// Id of input
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to media file
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }

        /// <summary>
        /// Specifies the algorithm how the stream in the input file will be selected. Only POSITION_ABSOLUTE is supported.
        /// </summary>
        [JsonProperty(PropertyName = "selectionMode")]
        public StreamSelectionMode? SelectionMode { get; set; }

        /// <summary>
        /// Position of the stream
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }
    }
}
