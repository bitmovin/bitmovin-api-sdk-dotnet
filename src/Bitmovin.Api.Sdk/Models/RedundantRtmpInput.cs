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
    /// RedundantRtmpInput
    /// </summary>

    public class RedundantRtmpInput : Input
    {
        /// <summary>
        /// When there is no input signal present and this threshold in seconds is reached it will switch to another ingest point
        /// </summary>
        [JsonProperty(PropertyName = "delayThreshold")]
        public int? DelayThreshold { get; set; }
        
        /// <summary>
        /// IngestPoints
        /// </summary>
        [JsonProperty(PropertyName = "ingestPoints")]
        public List<RtmpIngestPoint> IngestPoints { get; set; } = new List<RtmpIngestPoint>();
    }

}
