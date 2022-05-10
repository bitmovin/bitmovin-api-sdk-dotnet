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
        /// ID of an Input resource defining the input storage. Required if &#39;inputStreamId&#39; is not set.
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to an input media file. Required if &#39;inputStreamId&#39; is not set.
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }

        /// <summary>
        /// Specifies the strategy for selecting a stream from the input file. Must not be set when &#39;inputStreamId&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "selectionMode")]
        public StreamSelectionMode? SelectionMode { get; set; }

        /// <summary>
        /// Position of the stream to be selected from the input file (zero-based). Must not be set in combination with selectionMode &#39;AUTO&#39;, defaults to 0 for any other selectionMode.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }

        /// <summary>
        /// Set this property instead of all others to reference an InputStream resource (e.g. an Ingest-, Trimming- or ConcatenationInputStream)
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
