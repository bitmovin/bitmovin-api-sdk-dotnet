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
    /// Cumulative immutable result generation for a Live Analysis
    /// </summary>
    public class AiSceneAnalysisLiveResult
    {
        /// <summary>
        /// ID of the Live Analysis resource (required)
        /// </summary>
        [JsonProperty(PropertyName = "analysisId")]
        public string AnalysisId { get; set; }

        /// <summary>
        /// ID of the Encoding associated with the Analysis (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// Monotonically increasing generation sequence, starting at 1 (required)
        /// </summary>
        [JsonProperty(PropertyName = "sequence")]
        public long? Sequence { get; set; }

        /// <summary>
        /// Time at which the AI analysis produced this result generation (required)
        /// </summary>
        [JsonProperty(PropertyName = "producedAt")]
        public DateTime? ProducedAt { get; set; }

        /// <summary>
        /// Whether AI analysis produced this as the final result generation. This does not by itself imply that the Analysis completed successfully. (required)
        /// </summary>
        [JsonProperty(PropertyName = "isFinal")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Start of cumulative analyzed coverage on the monotonic analysis timeline (required)
        /// </summary>
        [JsonProperty(PropertyName = "analyzedStartTimeSeconds")]
        public double? AnalyzedStartTimeSeconds { get; set; }

        /// <summary>
        /// End of cumulative analyzed coverage on the monotonic analysis timeline (required)
        /// </summary>
        [JsonProperty(PropertyName = "analyzedEndTimeSeconds")]
        public double? AnalyzedEndTimeSeconds { get; set; }

        /// <summary>
        /// Cumulative closed source gaps on the monotonic analysis timeline (required)
        /// </summary>
        [JsonProperty(PropertyName = "sourceGaps")]
        public List<AiSceneAnalysisLiveSourceGap> SourceGaps { get; set; } = new List<AiSceneAnalysisLiveSourceGap>();

        /// <summary>
        /// Producer metadata for this generation (required)
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public AiSceneAnalysisLiveResultMetadata Metadata { get; set; }

        /// <summary>
        /// Cumulative immutable observations. Existing observations retain the same ID and content across later generations. Each time range identifies the analyzed media window that produced the observation, not an exact event location. (required)
        /// </summary>
        [JsonProperty(PropertyName = "observations")]
        public List<AiSceneAnalysisLiveObservation> Observations { get; set; } = new List<AiSceneAnalysisLiveObservation>();
    }
}
