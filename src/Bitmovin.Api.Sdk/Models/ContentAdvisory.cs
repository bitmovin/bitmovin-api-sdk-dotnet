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
    /// A content advisory reported for a shot, based on detected imagery or a conservative assumption when the analysis was blocked.
    /// </summary>
    public class ContentAdvisory
    {
        /// <summary>
        /// Kind of advisory-relevant imagery reported, or conservatively assumed when the shot has status BLOCKED. (required)
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public AdvisoryCategory? Category { get; set; }

        /// <summary>
        /// Confidence tier derived from the visual evidence reported by the analysis, for prioritizing human review rather than as a calibrated probability. (required)
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public AdvisoryConfidence? Confidence { get; set; }

        /// <summary>
        /// Explanation of the reported visual evidence, or of the conservative assumption when the shot could not be assessed. Retains its original value in language-specific results.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
    }
}
