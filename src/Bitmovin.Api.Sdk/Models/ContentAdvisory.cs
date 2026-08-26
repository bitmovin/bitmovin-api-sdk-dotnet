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
    /// A single piece of advisory-relevant imagery detected within a shot, for example for regulatory on-screen disclaimers
    /// </summary>
    public class ContentAdvisory
    {
        /// <summary>
        /// The kind of advisory-relevant imagery that was detected (required)
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public AdvisoryCategory? Category { get; set; }

        /// <summary>
        /// The model&#39;s own certainty in this detection. Intended to help prioritise human review rather than as a threshold for discarding advisories: detection is tuned to flag uncertain cases rather than miss them, and shots that could not be analysed are reported with LOW confidence (required)
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public AdvisoryConfidence? Confidence { get; set; }

        /// <summary>
        /// A short explanation of what was seen in the shot
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
    }
}
