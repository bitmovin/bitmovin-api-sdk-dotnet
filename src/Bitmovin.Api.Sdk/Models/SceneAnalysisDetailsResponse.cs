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
    /// VOD analysis of an encoded video. Field availability depends on enabled features and the analysis version. The REST response includes only fields defined by this API; asset-description.json files in customer outputs can contain additional fields. Empty arrays are omitted. Some unavailable values are returned as null, as noted on individual fields. Empty or missing values alone do not establish whether a feature was assessed. In language-specific results, free-text fields are translated into the requested language unless otherwise noted.
    /// </summary>
    public class SceneAnalysisDetailsResponse
    {
        /// <summary>
        /// Scenes identified in the video. (required)
        /// </summary>
        [JsonProperty(PropertyName = "scenes")]
        public List<Scene> Scenes { get; set; } = new List<Scene>();

        /// <summary>
        /// Duration of the analyzed video in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// AI-generated summary of the video as a whole. (required)
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Inferred title representing the analyzed content as a whole. If omitted or null, the title is not available.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Free-text keywords describing the video as a whole. Preserve the returned spelling and case. (required)
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// AI-estimated content ratings for the indicated regions and rating systems. (required)
        /// </summary>
        [JsonProperty(PropertyName = "ratings")]
        public List<Rating> Ratings { get; set; } = new List<Rating>();

        /// <summary>
        /// Sensitive topics for the video as a whole, in free text. This list can differ from the combined scene-level topics. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveTopics")]
        public List<string> SensitiveTopics { get; set; } = new List<string>();

        /// <summary>
        /// Distinct IAB Content Taxonomy identifiers drawn from the scenes&#39; IAB sensitive-topic annotations. The list can be empty or unavailable even when individual scenes have topic annotations. (required)
        /// </summary>
        [JsonProperty(PropertyName = "iabSensitiveTopicTaxonomies")]
        public List<string> IabSensitiveTopicTaxonomies { get; set; } = new List<string>();

        /// <summary>
        /// Language codes identified for spoken dialogue or narration in the source content. Theme-song vocals, lyrics, music and written text are excluded. The list can be empty when no codes were identified, including when the input has no audio stream. These codes do not indicate available translations.
        /// </summary>
        [JsonProperty(PropertyName = "inputLanguageCodes")]
        public List<string> InputLanguageCodes { get; set; } = new List<string>();

        /// <summary>
        /// Credits extracted from the video&#39;s on-screen text.
        /// </summary>
        [JsonProperty(PropertyName = "credits")]
        public Credits Credits { get; set; }

        /// <summary>
        /// Information about the analysis that generated this result. (required)
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }
    }
}
