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
    /// Setting
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// Location of the scene.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Time of day described by the analysis, in free text rather than a fixed vocabulary.
        /// </summary>
        [JsonProperty(PropertyName = "timeOfDay")]
        public string TimeOfDay { get; set; }

        /// <summary>
        /// Description of the setting&#39;s atmosphere.
        /// </summary>
        [JsonProperty(PropertyName = "atmosphere")]
        public Atmosphere Atmosphere { get; set; }
    }
}
