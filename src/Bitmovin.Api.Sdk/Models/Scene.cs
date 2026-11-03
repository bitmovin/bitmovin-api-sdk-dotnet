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
    /// Scene
    /// </summary>
    public class Scene
    {
        /// <summary>
        /// Short AI-generated title describing the scene.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Start time of the scene in seconds from the beginning of the video.
        /// </summary>
        [JsonProperty(PropertyName = "startInSeconds")]
        public double? StartInSeconds { get; set; }

        /// <summary>
        /// End time of the scene in seconds from the beginning of the video.
        /// </summary>
        [JsonProperty(PropertyName = "endInSeconds")]
        public double? EndInSeconds { get; set; }

        /// <summary>
        /// Identifier assigned to this scene within the analysis result.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Structured description of this scene.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public Content Content { get; set; }

        /// <summary>
        /// Concise summary of the scene.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Detailed description of the scene, providing more context than summary.
        /// </summary>
        [JsonProperty(PropertyName = "verboseSummary")]
        public string VerboseSummary { get; set; }

        /// <summary>
        /// Sensitive topics identified in this scene, expressed as free text rather than taxonomy identifiers. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveTopics")]
        public List<string> SensitiveTopics { get; set; } = new List<string>();

        /// <summary>
        /// Free-text keywords describing this scene. Preserve the returned spelling and case. (required)
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// IAB classification of this scene.
        /// </summary>
        [JsonProperty(PropertyName = "iab")]
        public IABTaxonomy Iab { get; set; }

        /// <summary>
        /// The detected type of scene based on content analysis
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SceneType? Type { get; set; }

        /// <summary>
        /// Camera shots with available analysis associated with this scene. The list can be empty or omitted and need not include every shot.
        /// </summary>
        [JsonProperty(PropertyName = "shots")]
        public List<Shot> Shots { get; set; } = new List<Shot>();

        /// <summary>
        /// Suitability assessment for an ad break at the end of this scene. This does not confirm that an ad was placed.
        /// </summary>
        [JsonProperty(PropertyName = "adOpportunityInformation")]
        public AdOpportunity AdOpportunityInformation { get; set; }
    }
}
