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
    /// Represents a continuous camera shot within a scene, containing detailed visual analysis including subjects, timing, and descriptive metadata
    /// </summary>
    public class Shot
    {
        /// <summary>
        /// The start time of the shot in seconds from the beginning of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "startInSeconds")]
        public decimal? StartInSeconds { get; set; }

        /// <summary>
        /// The end time of the shot in seconds from the beginning of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "endInSeconds")]
        public decimal? EndInSeconds { get; set; }

        /// <summary>
        /// A comprehensive textual description of the visual content, action, and context within this shot
        /// </summary>
        [JsonProperty(PropertyName = "detailedDescription")]
        public string DetailedDescription { get; set; }

        /// <summary>
        /// A list of relevant keywords and tags that describe the content, themes, or notable elements in this shot
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// A collection of the primary subjects or objects detected and tracked within this shot, including their positions and characteristics
        /// </summary>
        [JsonProperty(PropertyName = "mainSubjects")]
        public List<MainSubject> MainSubjects { get; set; } = new List<MainSubject>();
    }
}
