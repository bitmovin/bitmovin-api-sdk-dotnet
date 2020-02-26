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
    /// TsProgramMapTableConfiguration
    /// </summary>
    public class TsProgramMapTableConfiguration
    {
        /// <summary>
        /// An integer value. Packet Identifier (PID) for the MPEG Transport Stream PMT.
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public int? Pid { get; set; }
    }
}
