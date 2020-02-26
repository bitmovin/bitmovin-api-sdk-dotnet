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
    /// TsProgramClockReferenceConfiguration
    /// </summary>
    public class TsProgramClockReferenceConfiguration
    {
        /// <summary>
        /// An integer value. Packet Identifier (PID) for the MPEG Transport Stream PCR. This should generally point to the video stream PID. If it is not explicitly set it will point to the video stream PID if exists, otherwise to the audio stream PID.
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public int? Pid { get; set; }

        /// <summary>
        /// An integer value. Nominal time between MPEG Transport Stream PCRs in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }
    }
}
