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
    /// TsStreamConfiguration
    /// </summary>

    public class TsStreamConfiguration
    {
        /// <summary>
        /// The UUID of the stream to which this configuration belongs to. This has to be a ID of a stream that has been added to the current muxing. (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        /// <summary>
        /// An integer value. MPEG Transport Stream Packet Identifier (PID) for this stream. (required)
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public int? Pid { get; set; }
    }

}
