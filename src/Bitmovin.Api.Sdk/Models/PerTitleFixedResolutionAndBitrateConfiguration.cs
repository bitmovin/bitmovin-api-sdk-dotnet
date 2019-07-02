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
    /// PerTitleFixedResolutionAndBitrateConfiguration
    /// </summary>

    public class PerTitleFixedResolutionAndBitrateConfiguration
    {
        /// <summary>
        /// Number of forced renditions above the highest fixed representation (e.g. FIXED_RESOLUTION_AND_BITRATE). Forced renditions will be added, also if the Per-Title algorithm chooses the user defined force rendition to be the highest one.
        /// </summary>
        [JsonProperty(PropertyName = "forcedRenditionAboveHighestFixedRepresentation")]
        public int? ForcedRenditionAboveHighestFixedRepresentation { get; set; }
        
        /// <summary>
        /// The factor to calculate the bitrate that will be chosen based on the bitrate of the last FIXED_RESOLUTION.
        /// </summary>
        [JsonProperty(PropertyName = "forcedRenditionAboveHighestFixedRepresentationFactor")]
        public double? ForcedRenditionAboveHighestFixedRepresentationFactor { get; set; }
        
        /// <summary>
        /// Mode to calculate the bitrate of the next representation
        /// </summary>
        [JsonProperty(PropertyName = "forcedRenditionAboveHighestFixedRepresentationCalculationMode")]
        public PerTitleFixedResolutionAndBitrateConfigurationMode? ForcedRenditionAboveHighestFixedRepresentationCalculationMode { get; set; }
    }

}
