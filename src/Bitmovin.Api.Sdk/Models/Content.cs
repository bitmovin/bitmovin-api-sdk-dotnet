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
    /// Content
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Selected people or characters described in this scene. An empty or omitted list can mean that no characters were identified or that character descriptions were unavailable. (required)
        /// </summary>
        [JsonProperty(PropertyName = "characters")]
        public List<Character> Characters { get; set; } = new List<Character>();

        /// <summary>
        /// Selected notable objects described in this scene; not an exhaustive object inventory. (required)
        /// </summary>
        [JsonProperty(PropertyName = "objects")]
        public List<SceneObject> Objects { get; set; } = new List<SceneObject>();

        /// <summary>
        /// Places and environmental conditions described in this scene. More than one setting can be reported. (required)
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public List<Setting> Settings { get; set; } = new List<Setting>();

        /// <summary>
        /// Narrative dynamics of this scene.
        /// </summary>
        [JsonProperty(PropertyName = "dynamics")]
        public SceneDynamics Dynamics { get; set; }
    }
}
