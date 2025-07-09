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
    /// AutomaticAdPlacementPosition
    /// </summary>
    public class AutomaticAdPlacementPosition
    {
        /// <summary>
        /// Position of the ad placement in seconds. (required)
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public double? Position { get; set; }

        /// <summary>
        /// Maximum deviation in seconds to the ad placement position. (required)
        /// </summary>
        [JsonProperty(PropertyName = "maxDeviation")]
        public double? MaxDeviation { get; set; }

        /// <summary>
        /// The desired duration in seconds of the ad to be inserted.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
    }
}
