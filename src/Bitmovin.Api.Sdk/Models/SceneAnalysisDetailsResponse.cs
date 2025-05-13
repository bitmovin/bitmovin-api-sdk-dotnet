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
    /// SceneAnalysisDetailsResponse
    /// </summary>
    public class SceneAnalysisDetailsResponse
    {
        /// <summary>
        /// Scenes
        /// </summary>
        [JsonProperty(PropertyName = "scenes")]
        public List<Scene> Scenes { get; set; } = new List<Scene>();

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Keywords
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// Ratings
        /// </summary>
        [JsonProperty(PropertyName = "ratings")]
        public List<Rating> Ratings { get; set; } = new List<Rating>();

        /// <summary>
        /// SensitiveTopics
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveTopics")]
        public List<string> SensitiveTopics { get; set; } = new List<string>();

        /// <summary>
        /// IabSensitiveTopicTaxonomies
        /// </summary>
        [JsonProperty(PropertyName = "iabSensitiveTopicTaxonomies")]
        public List<string> IabSensitiveTopicTaxonomies { get; set; } = new List<string>();

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }
    }
}
