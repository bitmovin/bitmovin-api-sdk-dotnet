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
    /// StreamPerTitleFixedResolutionAndBitrateSettings
    /// </summary>

    public class StreamPerTitleFixedResolutionAndBitrateSettings
    {
        /// <summary>
        /// The minimum bitrate that will be used for that template.
        /// </summary>
        [JsonProperty(PropertyName = "minBitrate")]
        public int? MinBitrate { get; set; }
        
        /// <summary>
        /// The maximum bitrate that will be used for that template.
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrate")]
        public int? MaxBitrate { get; set; }
        
        /// <summary>
        /// Bitrate selection mode
        /// </summary>
        [JsonProperty(PropertyName = "bitrateSelectionMode")]
        public BitrateSelectionMode? BitrateSelectionMode { get; set; }
        
        /// <summary>
        /// Low complexity boundary for max bitrate
        /// </summary>
        [JsonProperty(PropertyName = "lowComplexityBoundaryForMaxBitrate")]
        public int? LowComplexityBoundaryForMaxBitrate { get; set; }
        
        /// <summary>
        /// High complexity boundary for max bitrate
        /// </summary>
        [JsonProperty(PropertyName = "highComplexityBoundaryForMaxBitrate")]
        public int? HighComplexityBoundaryForMaxBitrate { get; set; }
    }

}
