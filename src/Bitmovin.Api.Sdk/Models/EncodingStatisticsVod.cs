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
    /// EncodingStatisticsVod
    /// </summary>
    public class EncodingStatisticsVod : EncodingStatistics
    {
        /// <summary>
        /// Time in seconds encoded for this encoding. (required)
        /// </summary>
        [JsonProperty(PropertyName = "timeEnqueued")]
        public long? TimeEnqueued { get; set; }

        /// <summary>
        /// The realtime factor. (required)
        /// </summary>
        [JsonProperty(PropertyName = "realtimeFactor")]
        public double? RealtimeFactor { get; set; }
    }
}
