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
    /// BroadcastTsInputStreamConfiguration
    /// </summary>

    public class BroadcastTsInputStreamConfiguration
    {
        /// <summary>
        /// The UUID of the stream to which this configuration belongs to. This has to be a ID of a stream that has been added to the current muxing.
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        /// <summary>
        /// An integer value. Packet Identifier (PID) for this stream.
        /// </summary>
        [JsonProperty(PropertyName = "packetIdentifier")]
        public int? PacketIdentifier { get; set; }
        
        /// <summary>
        /// Start stream with initial discontinuity indicator set to one. If true, set the discontinuity indicator in the first packet for this PID.
        /// </summary>
        [JsonProperty(PropertyName = "startWithDiscontinuityIndicator")]
        public bool? StartWithDiscontinuityIndicator { get; set; }
        
        /// <summary>
        /// Align access units to PES packets. If true, align access units to PES packet headers. Uses adaptation field stuffing to position an access unit at the beginning of each PES packet.
        /// </summary>
        [JsonProperty(PropertyName = "alignPes")]
        public bool? AlignPes { get; set; }
        
        /// <summary>
        /// SetRaiOnAu
        /// </summary>
        [JsonProperty(PropertyName = "setRaiOnAu")]
        public RaiUnit? SetRaiOnAu { get; set; }
    }

}
