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
    /// PccVerdictLegendEntry
    /// </summary>
    public class PccVerdictLegendEntry
    {
        /// <summary>
        /// The mark the grid draws for every verdict reading as this entry&#39;s label. (required)
        /// </summary>
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// The reader&#39;s word for those verdicts — &#x60;Supported&#x60;, &#x60;Not measured&#x60;, and so on. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// What that word means here. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sentence")]
        public string Sentence { get; set; }

        /// <summary>
        /// False where these verdicts say something about the measurement rather than about the device. Folding those into \&quot;not supported\&quot; is how this dataset gets misread. (required)
        /// </summary>
        [JsonProperty(PropertyName = "aboutTheDevice")]
        public bool? AboutTheDevice { get; set; }
    }
}
