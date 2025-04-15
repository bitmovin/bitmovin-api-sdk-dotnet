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
    /// Atmosphere
    /// </summary>
    public class Atmosphere
    {
        /// <summary>
        /// Mood
        /// </summary>
        [JsonProperty(PropertyName = "mood")]
        public string Mood { get; set; }

        /// <summary>
        /// Lighting
        /// </summary>
        [JsonProperty(PropertyName = "lighting")]
        public string Lighting { get; set; }

        /// <summary>
        /// Weather
        /// </summary>
        [JsonProperty(PropertyName = "weather")]
        public string Weather { get; set; }
    }
}
