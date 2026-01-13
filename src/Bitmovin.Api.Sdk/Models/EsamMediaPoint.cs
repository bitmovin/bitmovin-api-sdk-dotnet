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
    /// ESAM media point following the SCTE-250 standard
    /// </summary>
    public class EsamMediaPoint
    {
        /// <summary>
        /// ISO 8601 date-time specifying when the signal should be matched and inserted into the live stream
        /// </summary>
        [JsonProperty(PropertyName = "matchTime")]
        public DateTime? MatchTime { get; set; }

        /// <summary>
        /// Array of ESAM signals containing SCTE-35 binary data. At least one signal is required (required)
        /// </summary>
        [JsonProperty(PropertyName = "signals")]
        public List<EsamSignal> Signals { get; set; } = new List<EsamSignal>();

        /// <summary>
        /// Optional array of ESAM conditions with timing offsets and directional markers (OUT/IN) for signaling content boundaries
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public List<EsamCondition> Conditions { get; set; } = new List<EsamCondition>();
    }
}
