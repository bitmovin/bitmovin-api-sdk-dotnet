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
    /// PccPicture
    /// </summary>
    public class PccPicture
    {
        /// <summary>
        /// The mark the cell wears. &#x60;hdrLegend&#x60; explains it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "mark")]
        public string Mark { get; set; }

        /// <summary>
        /// Confidence
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public PccHdrConfidence? Confidence { get; set; }

        /// <summary>
        /// Whether this is a result somebody should chase, which is not how confident it is. (required)
        /// </summary>
        [JsonProperty(PropertyName = "actionable")]
        public bool? Actionable { get; set; }

        /// <summary>
        /// Sentence
        /// </summary>
        [JsonProperty(PropertyName = "sentence")]
        public string Sentence { get; set; }
    }
}
