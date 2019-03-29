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
    /// BillableEncodingFeatureMinutes
    /// </summary>

    public class BillableEncodingFeatureMinutes
    {
        /// <summary>
        /// The name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "featureType")]
        public string FeatureType { get; set; }
        
        /// <summary>
        /// Encoded minutes related to this feature.
        /// </summary>
        [JsonProperty(PropertyName = "encodedMinutes")]
        public double? EncodedMinutes { get; set; }
        
        /// <summary>
        /// The multiplier used for this feature.
        /// </summary>
        [JsonProperty(PropertyName = "featureMultiplier")]
        public double? FeatureMultiplier { get; set; }
        
        /// <summary>
        /// The billable minutes related to this feature.
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; set; }
    }

}
