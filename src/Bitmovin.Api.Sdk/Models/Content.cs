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
        /// Characters
        /// </summary>
        [JsonProperty(PropertyName = "characters")]
        public List<Character> Characters { get; set; } = new List<Character>();

        /// <summary>
        /// Objects
        /// </summary>
        [JsonProperty(PropertyName = "objects")]
        public List<SceneObject> Objects { get; set; } = new List<SceneObject>();

        /// <summary>
        /// Settings
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public List<Setting> Settings { get; set; } = new List<Setting>();
    }
}
