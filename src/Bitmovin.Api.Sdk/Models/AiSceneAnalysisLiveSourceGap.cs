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
    /// AiSceneAnalysisLiveSourceGap
    /// </summary>
    public class AiSceneAnalysisLiveSourceGap
    {
        /// <summary>
        /// Gap start on the monotonic analysis timeline (required)
        /// </summary>
        [JsonProperty(PropertyName = "startTimeSeconds")]
        public double? StartTimeSeconds { get; set; }

        /// <summary>
        /// Gap end on the monotonic analysis timeline (required)
        /// </summary>
        [JsonProperty(PropertyName = "endTimeSeconds")]
        public double? EndTimeSeconds { get; set; }

        /// <summary>
        /// Reason for the source gap (required)
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public AiSceneAnalysisLiveSourceGapReason? Reason { get; set; }
    }
}
