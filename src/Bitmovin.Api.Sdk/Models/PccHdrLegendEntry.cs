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
    /// PccHdrLegendEntry
    /// </summary>
    public class PccHdrLegendEntry
    {
        /// <summary>
        /// The mark an HDR result wears on the cell. (required)
        /// </summary>
        [JsonProperty(PropertyName = "mark")]
        public string Mark { get; set; }

        /// <summary>
        /// The reader&#39;s word for it — &#x60;The frames really were HDR&#x60;, &#x60;The device claims HDR&#x60;, and so on. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Which instrument established the picture, where anything did. (required)
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public PccHdrConfidence? Confidence { get; set; }

        /// <summary>
        /// What that mark establishes, and what it does not. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sentence")]
        public string Sentence { get; set; }

        /// <summary>
        /// Whether a result wearing this mark is one somebody should chase, which is not the same as how confident it is. (required)
        /// </summary>
        [JsonProperty(PropertyName = "actionable")]
        public bool? Actionable { get; set; }
    }
}
