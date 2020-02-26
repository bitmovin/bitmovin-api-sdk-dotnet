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
    /// StatisticsPerMuxing
    /// </summary>
    public class StatisticsPerMuxing
    {
        /// <summary>
        /// ID of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }

        /// <summary>
        /// ID of the muxing (required)
        /// </summary>
        [JsonProperty(PropertyName = "muxingId")]
        public string MuxingId { get; set; }

        /// <summary>
        /// Multiplier for the encoded minutes. Depends on muxing type. (required)
        /// </summary>
        [JsonProperty(PropertyName = "multiplicator")]
        public double? Multiplicator { get; set; }

        /// <summary>
        /// Encoded bytes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodedBytes")]
        public long? EncodedBytes { get; set; }

        /// <summary>
        /// Resulting minutes you will be charged for. (required)
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public double? BillableMinutes { get; set; }

        /// <summary>
        /// MuxingType
        /// </summary>
        [JsonProperty(PropertyName = "muxingType")]
        public MuxingType? MuxingType { get; set; }
    }
}
