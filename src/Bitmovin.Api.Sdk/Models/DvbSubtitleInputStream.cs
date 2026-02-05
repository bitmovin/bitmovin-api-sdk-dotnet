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
#pragma warning disable CS0414
        private readonly string _type = "DVB_SUBTITLE";
#pragma warning restore CS0414

        /// <summary>
        /// ID of an Input resource defining the input storage
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to an input media file
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }

        /// <summary>
        /// Specifies the strategy for selecting a stream from the input file. Supported values for VOD encodings: AUTO, POSITION_ABSOLUTE, SUBTITLE_RELATIVE. Supported values for LIVE encodings: POSITION_ABSOLUTE
        /// </summary>
        [JsonProperty(PropertyName = "selectionMode")]
        public StreamSelectionMode? SelectionMode { get; set; }

        /// <summary>
        /// Position of the stream to be selected from the input file (zero-based). Must not be set in combination with selectionMode &#39;AUTO&#39;, defaults to 0 for any other selectionMode.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }
    }
}
