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
    /// PerTitleConfiguration
    /// </summary>

    public class PerTitleConfiguration
    {
        /// <summary>
        /// The minimum bitrate that will be used by the Per-Title algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "minBitrate")]
        public int? MinBitrate { get; set; }
        
        /// <summary>
        /// The maximum bitrate that will be used by the Per-Title algorithm. It will not generate any rendition with a higher bitrate.
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrate")]
        public int? MaxBitrate { get; set; }
        
        /// <summary>
        /// The minimum ratio between the bitrates of generated renditions, e.g. if the first bitrate is 240,000, a minimum ratio of 1.5 will require the next higher bitrate to be at least 360,000
        /// </summary>
        [JsonProperty(PropertyName = "minBitrateStepSize")]
        public double? MinBitrateStepSize { get; set; }
        
        /// <summary>
        /// The maximum ratio between the bitrates of neighbouring renditions, e.g., if the first bitrate is 240,000, a maximum ratio of 1.5 will require the next higher bitrate to be at most 360,000
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrateStepSize")]
        public double? MaxBitrateStepSize { get; set; }
        
        /// <summary>
        /// AutoRepresentations
        /// </summary>
        [JsonProperty(PropertyName = "autoRepresentations")]
        public AutoRepresentation AutoRepresentations { get; set; }
        
        /// <summary>
        /// Will modify the assumed complexity for the Per-Title algorithm (&gt; 0.0). Values higher than 1 will increase complexity and thus select smaller resolutions for given bitrates. This will also result in a higher bitrate for the top rendition. Values lower than 1 will decrease assumed complexity and thus select higher resolutions for given bitrates and also decrease the bitrate of the top rendition
        /// </summary>
        [JsonProperty(PropertyName = "complexityFactor")]
        public double? ComplexityFactor { get; set; }
        
        /// <summary>
        /// Additional configuration for fixed resolution and bitrate templates
        /// </summary>
        [JsonProperty(PropertyName = "fixedResolutionAndBitrateConfiguration")]
        public PerTitleFixedResolutionAndBitrateConfiguration FixedResolutionAndBitrateConfiguration { get; set; }
    }

}
