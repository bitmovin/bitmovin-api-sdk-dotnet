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
    /// The scene segment that best matches a semantic-search query
    /// </summary>
    public class SceneAnalysisMatchingSegment
    {
        /// <summary>
        /// ID of the matching scene (required)
        /// </summary>
        [JsonProperty(PropertyName = "sceneId")]
        public string SceneId { get; set; }

        /// <summary>
        /// The detected type of the matching scene
        /// </summary>
        [JsonProperty(PropertyName = "sceneType")]
        public SceneType? SceneType { get; set; }

        /// <summary>
        /// The title of the matching scene
        /// </summary>
        [JsonProperty(PropertyName = "sceneTitle")]
        public string SceneTitle { get; set; }

        /// <summary>
        /// A description of the matching scene
        /// </summary>
        [JsonProperty(PropertyName = "sceneDescription")]
        public string SceneDescription { get; set; }

        /// <summary>
        /// The start time of the matching segment in seconds from the beginning of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "startInSeconds")]
        public double? StartInSeconds { get; set; }

        /// <summary>
        /// The end time of the matching segment in seconds from the beginning of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "endInSeconds")]
        public double? EndInSeconds { get; set; }
    }
}
