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
    /// Character
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Description of the character&#39;s visible appearance.
        /// </summary>
        [JsonProperty(PropertyName = "characterAppearance")]
        public CharacterAppearance CharacterAppearance { get; set; }

        /// <summary>
        /// Name assigned to the character when identified. Can be null or an empty string, even when a summary names the person.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of the performer credited for the resolved character role when uniquely matched. Can be null or an empty string when identity or the role-to-performer match is unresolved. Retains its original value in language-specific results.
        /// </summary>
        [JsonProperty(PropertyName = "playedBy")]
        public string PlayedBy { get; set; }

        /// <summary>
        /// Free-text description of the character and their role or actions in this scene.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
