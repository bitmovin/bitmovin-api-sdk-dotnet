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
    /// BroadcastTsSubtitleInputStreamConfiguration
    /// </summary>
    public class BroadcastTsSubtitleInputStreamConfiguration
    {
        /// <summary>
        /// The UUID of the subtitle stream to which this configuration belongs to. This has to be an ID of an subtitle stream that has been added to the current muxing. 
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }

        /// <summary>
        /// An integer value. Packet Identifier (PID) for this stream.
        /// </summary>
        [JsonProperty(PropertyName = "packetIdentifier")]
        public int? PacketIdentifier { get; set; }

        /// <summary>
        /// The rate parameter determines the maximum rate in bits per second that should be used for the subtitle stream. The valid range is &#x60;100&#x60; to &#x60;60 000 000&#x60; bps or &#x60;0&#x60;. If the value is set to 0, we will examine the first 100 packets of subtitle packet data and use the highest rate that was computed. If the value is set too low, not enough to accommodate the subtitle bit-rate, then some PES packets corresponding to DVB subtitle stream will be dropped. This parameter is optional and the default value is 0. 
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public int? Rate { get; set; }
    }
}
