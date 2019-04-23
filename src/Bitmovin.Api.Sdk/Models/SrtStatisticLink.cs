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
    /// SrtStatisticLink
    /// </summary>

    public class SrtStatisticLink
    {
        /// <summary>
        /// Bandwidth
        /// </summary>
        [JsonProperty(PropertyName = "bandwidth")]
        public double? Bandwidth { get; set; }
        
        /// <summary>
        /// MaxBandwidth
        /// </summary>
        [JsonProperty(PropertyName = "maxBandwidth")]
        public double? MaxBandwidth { get; set; }
        
        /// <summary>
        /// Rtt
        /// </summary>
        [JsonProperty(PropertyName = "rtt")]
        public double? Rtt { get; set; }
    }

}
