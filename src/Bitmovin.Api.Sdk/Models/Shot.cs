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
    /// A detected shot associated with one scene. A shot can cross a scene boundary or lie entirely outside its associated scene. Use the shot&#39;s own timestamps to locate its content.
    /// </summary>
    public class Shot
    {
        /// <summary>
        /// The start time of the shot in seconds from the beginning of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "startInSeconds")]
        public double? StartInSeconds { get; set; }

        /// <summary>
        /// The end time of the shot in seconds from the beginning of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "endInSeconds")]
        public double? EndInSeconds { get; set; }

        /// <summary>
        /// Description of the shot&#39;s visual content, action and context.
        /// </summary>
        [JsonProperty(PropertyName = "detailedDescription")]
        public string DetailedDescription { get; set; }

        /// <summary>
        /// Keywords describing the shot&#39;s content, themes or notable elements.
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
        /// Selected subjects or objects identified in this shot.
        /// </summary>
        [JsonProperty(PropertyName = "mainSubjects")]
        public List<MainSubject> MainSubjects { get; set; } = new List<MainSubject>();

        /// <summary>
        /// Content advisory results for this shot, or null when no assessment is available. Availability depends on whether advisory analysis was enabled and supported by the analysis version.
        /// </summary>
        [JsonProperty(PropertyName = "shotAdvisories")]
        public ShotAdvisories ShotAdvisories { get; set; }
    }
}
