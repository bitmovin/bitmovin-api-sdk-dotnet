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
    /// LiveEncodingStats
    /// </summary>

    public class LiveEncodingStats
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public LiveEncodingStatus Status { get; set; }
        
        /// <summary>
        /// List of events
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public List<LiveEncodingStatsEvent> Events { get; set; }
        
        /// <summary>
        /// List of statistics
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public List<StreamInfos> Statistics { get; set; }
    }

}
