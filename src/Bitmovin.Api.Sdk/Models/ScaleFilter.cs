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
    /// ScaleFilter
    /// </summary>

    public class ScaleFilter : Filter
    {
        /// <summary>
        /// The width of the output frame in pixel. If not set: codec configuration width will be used.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }
        
        /// <summary>
        /// The height of the output frame in pixel. If not set: codec configuration height will be used.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }
        
        /// <summary>
        /// ScalingAlgorithm
        /// </summary>
        [JsonProperty(PropertyName = "scalingAlgorithm")]
        public ScalingAlgorithm ScalingAlgorithm { get; set; }
        
        /// <summary>
        /// The numerator of the sample aspect ratio (also known as pixel aspect ratio). Must be set if sampleAspectRatioDenominator is set.
        /// </summary>
        [JsonProperty(PropertyName = "sampleAspectRatioNumerator")]
        public int? SampleAspectRatioNumerator { get; set; }
        
        /// <summary>
        /// The denominator of the sample aspect ratio (also known as pixel aspect ratio). Must be set if sampleAspectRatioNumerator is set.
        /// </summary>
        [JsonProperty(PropertyName = "sampleAspectRatioDenominator")]
        public int? SampleAspectRatioDenominator { get; set; }
    }

}
