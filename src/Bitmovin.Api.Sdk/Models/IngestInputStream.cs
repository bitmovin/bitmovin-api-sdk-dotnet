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
    /// IngestInputStream
    /// </summary>

    public class IngestInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "INGEST";

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
    }

}
