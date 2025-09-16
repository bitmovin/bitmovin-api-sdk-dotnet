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
        /// Title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// StartInSeconds
        /// </summary>
        [JsonProperty(PropertyName = "startInSeconds")]
        public decimal? StartInSeconds { get; set; }

        /// <summary>
        /// EndInSeconds
        /// </summary>
        [JsonProperty(PropertyName = "endInSeconds")]
        public decimal? EndInSeconds { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public Content Content { get; set; }

        /// <summary>
        /// Summary
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// VerboseSummary
        /// </summary>
        [JsonProperty(PropertyName = "verboseSummary")]
        public string VerboseSummary { get; set; }

        /// <summary>
        /// SensitiveTopics
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveTopics")]
        public List<string> SensitiveTopics { get; set; } = new List<string>();

        /// <summary>
        /// Keywords
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// Iab
        /// </summary>
        [JsonProperty(PropertyName = "iab")]
        public IABTaxonomy Iab { get; set; }

        /// <summary>
        /// The detected type of scene based on content analysis
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SceneType? Type { get; set; }
    }
}
