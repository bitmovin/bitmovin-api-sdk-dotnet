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
    /// ProgramDateTimePlacement
    /// </summary>
    public class ProgramDateTimePlacement
    {
        /// <summary>
        /// ProgramDateTimePlacementMode
        /// </summary>
        [JsonProperty(PropertyName = "programDateTimePlacementMode")]
        public ProgramDateTimePlacementMode? ProgramDateTimePlacementMode { get; set; }

        /// <summary>
        /// Interval for placing ProgramDateTime. Only required for SEGMENTS_INTERVAL or SECONDS_INTERVAL.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }
    }
}
