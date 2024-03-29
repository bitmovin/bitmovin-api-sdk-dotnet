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
    /// SrtStatisticRecv
    /// </summary>
    public class SrtStatisticRecv
    {
        /// <summary>
        /// Bytes
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public long? Bytes { get; set; }

        /// <summary>
        /// BytesDropped
        /// </summary>
        [JsonProperty(PropertyName = "bytesDropped")]
        public long? BytesDropped { get; set; }

        /// <summary>
        /// BytesLost
        /// </summary>
        [JsonProperty(PropertyName = "bytesLost")]
        public long? BytesLost { get; set; }

        /// <summary>
        /// MbitRate
        /// </summary>
        [JsonProperty(PropertyName = "mbitRate")]
        public double? MbitRate { get; set; }

        /// <summary>
        /// Packets
        /// </summary>
        [JsonProperty(PropertyName = "packets")]
        public long? Packets { get; set; }

        /// <summary>
        /// PacketsBelated
        /// </summary>
        [JsonProperty(PropertyName = "packetsBelated")]
        public long? PacketsBelated { get; set; }

        /// <summary>
        /// PacketsDropped
        /// </summary>
        [JsonProperty(PropertyName = "packetsDropped")]
        public long? PacketsDropped { get; set; }

        /// <summary>
        /// PacketsLost
        /// </summary>
        [JsonProperty(PropertyName = "packetsLost")]
        public long? PacketsLost { get; set; }

        /// <summary>
        /// PacketsRetransmitted
        /// </summary>
        [JsonProperty(PropertyName = "packetsRetransmitted")]
        public long? PacketsRetransmitted { get; set; }
    }
}
