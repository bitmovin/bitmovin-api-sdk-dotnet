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
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "REDUNDANT_RTMP";

        /// <summary>
        /// When there is no input signal present and this threshold in seconds is reached it will switch to another ingest point
        /// </summary>
        [JsonProperty(PropertyName = "delayThreshold")]
        public int? DelayThreshold { get; set; }

        /// <summary>
        /// Configuration for ingest points that use a dynamic IP based endpoint to stream to e.g.: rtmp://41.167.11.21/live Either ingestPoints **or** staticIngestPoints can be set 
        /// </summary>
        [JsonProperty(PropertyName = "ingestPoints")]
        public List<RtmpIngestPoint> IngestPoints { get; set; } = new List<RtmpIngestPoint>();

        /// <summary>
        /// Configuration for static ingest points. These ingest points use a consistent endpoint to stream to e.g.: rtmps://live-ingest.bitmovin.com/live Either ingestPoints **or** staticIngestPoints can be set 
        /// </summary>
        [JsonProperty(PropertyName = "staticIngestPoints")]
        public List<StaticRtmpIngestPoint> StaticIngestPoints { get; set; } = new List<StaticRtmpIngestPoint>();
    }
}
