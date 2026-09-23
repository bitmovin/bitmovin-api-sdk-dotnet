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
    /// Immutable consumer-visible observation produced from an analyzed media window
    /// </summary>
    public class AiSceneAnalysisLiveObservation
    {
        /// <summary>
        /// Stable opaque observation ID that remains unchanged across cumulative result generations (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Consumer-visible description of a development in the analyzed media (required)
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Start of the analyzed media window that produced the observation (required)
        /// </summary>
        [JsonProperty(PropertyName = "startTimeSeconds")]
        public double? StartTimeSeconds { get; set; }

        /// <summary>
        /// End of the analyzed media window that produced the observation (required)
        /// </summary>
        [JsonProperty(PropertyName = "endTimeSeconds")]
        public double? EndTimeSeconds { get; set; }
    }
}
