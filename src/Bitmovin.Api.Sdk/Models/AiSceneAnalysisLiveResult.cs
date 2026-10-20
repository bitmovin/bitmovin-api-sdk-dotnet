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
    /// Complete snapshot of a Live Analysis at a specific result sequence
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
        /// Monotonically increasing result sequence, starting at 1 (required)
        /// </summary>
        [JsonProperty(PropertyName = "sequence")]
        public long? Sequence { get; set; }

        /// <summary>
        /// Time at which the AI analysis produced this result snapshot (required)
        /// </summary>
        [JsonProperty(PropertyName = "producedAt")]
        public DateTime? ProducedAt { get; set; }

        /// <summary>
        /// UTC presentation-clock time in Unix milliseconds corresponding to media time zero. This origin is fixed for the Live Analysis; coverage, observation, key-moment, and source-gap times remain relative to it. It is not the source capture time or result publication time. (required)
        /// </summary>
        [JsonProperty(PropertyName = "mediaTimeOriginUnixMs")]
        public long? MediaTimeOriginUnixMs { get; set; }

        /// <summary>
        /// Whether this is the final result snapshot. This does not by itself imply that the Analysis completed successfully. (required)
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
        /// Cumulative closed source gaps on the monotonic analysis timeline. An empty or omitted array means there are no closed source gaps in this snapshot, not that the previous collection is unchanged.
        /// </summary>
        [JsonProperty(PropertyName = "sourceGaps")]
        public List<AiSceneAnalysisLiveSourceGap> SourceGaps { get; set; } = new List<AiSceneAnalysisLiveSourceGap>();

        /// <summary>
        /// Metadata for this result snapshot (required)
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public AiSceneAnalysisLiveResultMetadata Metadata { get; set; }

        /// <summary>
        /// Complete set of active observations for this result sequence. An empty or omitted array means there are no active observations in this snapshot, not that the previous collection is unchanged. Observations may be removed in later sequences. Observation IDs identify immutable observation content and are never reused. Each time range identifies the analyzed media window that produced the observation, not an exact event location.
        /// </summary>
        [JsonProperty(PropertyName = "observations")]
        public List<AiSceneAnalysisLiveObservation> Observations { get; set; } = new List<AiSceneAnalysisLiveObservation>();

        /// <summary>
        /// Complete set of current key moments for this result sequence, ordered by ascending startInSeconds. Ordering of moments with equal start times is unspecified. An empty or omitted array means there are no current key moments in this snapshot, not that the previous collection is unchanged.  Moments may be refined or withdrawn in later result sequences until the final result. A refined moment retains its ID; a withdrawn moment is absent from subsequent snapshots and its ID is never reused. Consumers identify moments by ID and detect changes through lastUpdatedSequence, not array position. Changing array position alone or marking the result final does not change lastUpdatedSequence.  Every referenced observation is active in the same result snapshot. Moment references are updated or moments withdrawn when supporting observations are replaced or removed. 
        /// </summary>
        [JsonProperty(PropertyName = "keyMoments")]
        public List<AiSceneAnalysisLiveKeyMoment> KeyMoments { get; set; } = new List<AiSceneAnalysisLiveKeyMoment>();
    }
}
