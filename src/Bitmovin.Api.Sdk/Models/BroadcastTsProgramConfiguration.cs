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
    /// BroadcastTsProgramConfiguration
    /// </summary>

    public class BroadcastTsProgramConfiguration
    {
        /// <summary>
        /// An integer value. Value for program_number field in Program Map Table (PMT). The value zero is reserved for the NIT PID entry in the PAT.
        /// </summary>
        [JsonProperty(PropertyName = "programNumber")]
        public int? ProgramNumber { get; set; }
        
        /// <summary>
        /// An integer value. Packet identifier (PID) to use for Program Map Table (PMT). Recommended value is 2 x programNumber.
        /// </summary>
        [JsonProperty(PropertyName = "pidForPMT")]
        public int? PidForPMT { get; set; }
        
        /// <summary>
        /// Insert Program Clock References (PCRs) on all packetized elemementary stream packets. When false, indicates that PCRs should be inserted on every PES header. This parameter is effective only when the PCR packet identifier is the same as a video or audio elementary stream.
        /// </summary>
        [JsonProperty(PropertyName = "insertProgramClockRefOnPes")]
        public bool? InsertProgramClockRefOnPes { get; set; }
    }

}
