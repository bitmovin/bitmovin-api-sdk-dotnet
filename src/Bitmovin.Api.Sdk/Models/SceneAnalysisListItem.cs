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
    /// SceneAnalysisListItem
    /// </summary>
    public class SceneAnalysisListItem
    {
        /// <summary>
        /// AI scene analysis ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// ID of the associated encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// Creation timestamp, returned as UTC in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ (required)
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Analysis description. Empty when analysis metadata is unavailable (required)
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Inferred title representing the analyzed content as a whole. If omitted or null, the title is not available.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Analysis keywords in their original order and casing, including duplicates. Omitted or empty when analysis metadata is unavailable; consumers must treat both representations as an empty list
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// Number of scenes in the analysis. Zero when analysis metadata is unavailable (required)
        /// </summary>
        [JsonProperty(PropertyName = "sceneCount")]
        public int? SceneCount { get; set; }

        /// <summary>
        /// Unique language codes for available translated analysis details in backend-defined deterministic order. Order and casing are returned unchanged. Omitted or empty when no translations are available; consumers must treat both representations as an empty list
        /// </summary>
        [JsonProperty(PropertyName = "outputLanguageCodes")]
        public List<string> OutputLanguageCodes { get; set; } = new List<string>();
    }
}
