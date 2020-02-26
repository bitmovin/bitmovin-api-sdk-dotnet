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
    /// ConvertSccCaption
    /// </summary>
    public class ConvertSccCaption : BitmovinResource
    {
        /// <summary>
        /// The input location to get the scc file from (required)
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public InputPath Input { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();

        /// <summary>
        /// Name of the captions file (required)
        /// </summary>
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// OutputFormat
        /// </summary>
        [JsonProperty(PropertyName = "outputFormat")]
        public StreamCaptionOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Optional settings when converting SCC to WebVTT
        /// </summary>
        [JsonProperty(PropertyName = "webVttSettings")]
        public ConvertSccCaptionWebVttSettings WebVttSettings { get; set; }
    }
}
