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
    /// BroadcastTsMuxing
    /// </summary>
    public class BroadcastTsMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "BROADCAST_TS";
#pragma warning restore CS0414

        /// <summary>
        /// Length of the segments in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }

        /// <summary>
        /// Name of the output file
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Configuration
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public BroadcastTsMuxingConfiguration Configuration { get; set; }
    }
}
