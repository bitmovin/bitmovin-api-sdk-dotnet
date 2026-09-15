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
    /// PccCombination
    /// </summary>
    public class PccCombination
    {
        /// <summary>
        /// The codec, as the shared contract spells it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// The content protection, as the shared contract spells it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "protection")]
        public string Protection { get; set; }

        /// <summary>
        /// The column heading, spelled the way a reader reads it rather than the way the catalogue spells it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Whether this column&#39;s stream is HDR. Read it here rather than out of the codec name: not every HDR codec spells &#x60;hdr10&#x60;, and the Dolby Vision ones never do. (required)
        /// </summary>
        [JsonProperty(PropertyName = "hdr")]
        public bool? Hdr { get; set; }
    }
}
