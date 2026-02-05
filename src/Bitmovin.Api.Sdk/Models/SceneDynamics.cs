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
    /// SceneDynamics
    /// </summary>
    public class SceneDynamics
    {
        /// <summary>
        /// The detected tension of the scene based on content analysis
        /// </summary>
        [JsonProperty(PropertyName = "tension")]
        public SceneTension? Tension { get; set; }

        /// <summary>
        /// The detected pacing of the scene based on content analysis
        /// </summary>
        [JsonProperty(PropertyName = "pacing")]
        public ScenePacing? Pacing { get; set; }
    }
}
