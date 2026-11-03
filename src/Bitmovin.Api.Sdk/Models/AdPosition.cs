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
    /// AdPosition
    /// </summary>
    public class AdPosition
    {
        /// <summary>
        /// Selected ad break position in seconds from the beginning of the video.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public double? Position { get; set; }

        /// <summary>
        /// Ad duration in seconds requested for this placement. Not set for breaks added at all scene boundaries, when the schedule entry has no duration, or when the encoder does not support ad durations.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
    }
}
