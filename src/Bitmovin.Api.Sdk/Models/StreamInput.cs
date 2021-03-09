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
    /// StreamInput
    /// </summary>
    public class StreamInput
    {
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
        /// Specifies the algorithm how the stream in the input file will be selected
        /// </summary>
        [JsonProperty(PropertyName = "selectionMode")]
        public StreamSelectionMode? SelectionMode { get; set; }

        /// <summary>
        /// Position of the stream
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }

        /// <summary>
        /// Set this property instead of all others to reference an ingest, trimming or concatenation input stream
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }

        /// <summary>
        /// Input analysis details  This property is populated after the encoding has finished 
        /// </summary>
        [JsonProperty(PropertyName = "analysisDetails")]
        public EncodingStreamInputDetails AnalysisDetails { get; internal set; }
    }
}
