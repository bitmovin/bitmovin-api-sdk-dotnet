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
    /// A key event in the analyzed media, supported by one or more active observations
    /// </summary>
    public class AiSceneAnalysisLiveKeyMoment
    {
        /// <summary>
        /// Opaque key moment ID unique within the Live Analysis. Stable through refinements and never reused after withdrawal. (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Result sequence that introduced or last changed this moment&#39;s importance level, times or observation references. Unchanged moments retain this value. (required)
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedSequence")]
        public long? LastUpdatedSequence { get; set; }

        /// <summary>
        /// Importance level, not a position within the result snapshot: 1 is highest and larger values indicate lower importance. Ties are allowed. Adding another moment does not by itself renumber existing importance levels. There is no upper bound or implied limit on the number of key moments. (required)
        /// </summary>
        [JsonProperty(PropertyName = "importanceLevel")]
        public int? ImportanceLevel { get; set; }

        /// <summary>
        /// Start of the key moment in seconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "startInSeconds")]
        public double? StartInSeconds { get; set; }

        /// <summary>
        /// End of the key moment in seconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "endInSeconds")]
        public double? EndInSeconds { get; set; }

        /// <summary>
        /// Time of the key moment&#39;s actual high point in seconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "anchorInSeconds")]
        public double? AnchorInSeconds { get; set; }

        /// <summary>
        /// IDs of active observations in the enclosing result that support this moment. Multiple key moments may reference the same observation. (required)
        /// </summary>
        [JsonProperty(PropertyName = "observations")]
        public List<string> Observations { get; set; } = new List<string>();
    }
}
