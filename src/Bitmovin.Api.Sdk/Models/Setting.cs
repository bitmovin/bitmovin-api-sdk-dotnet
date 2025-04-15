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
        /// Location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// TimeOfDay
        /// </summary>
        [JsonProperty(PropertyName = "timeOfDay")]
        public string TimeOfDay { get; set; }

        /// <summary>
        /// Atmosphere
        /// </summary>
        [JsonProperty(PropertyName = "atmosphere")]
        public Atmosphere Atmosphere { get; set; }
    }
}
