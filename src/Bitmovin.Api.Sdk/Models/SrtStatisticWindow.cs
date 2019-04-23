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
    /// SrtStatisticWindow
    /// </summary>

    public class SrtStatisticWindow
    {
        /// <summary>
        /// Congestion
        /// </summary>
        [JsonProperty(PropertyName = "congestion")]
        public long? Congestion { get; set; }
        
        /// <summary>
        /// Flight
        /// </summary>
        [JsonProperty(PropertyName = "flight")]
        public long? Flight { get; set; }
        
        /// <summary>
        /// Flow
        /// </summary>
        [JsonProperty(PropertyName = "flow")]
        public long? Flow { get; set; }
    }

}
