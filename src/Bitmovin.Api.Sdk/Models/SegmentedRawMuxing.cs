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
    /// SegmentedRawMuxing
    /// </summary>
    public class SegmentedRawMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "SEGMENTED_RAW";

        /// <summary>
        /// Length of the fragments in seconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }

        /// <summary>
        /// Segment naming policy (required)
        /// </summary>
        [JsonProperty(PropertyName = "segmentNaming")]
        public string SegmentNaming { get; set; }

        /// <summary>
        /// Number of segments which have been encoded
        /// </summary>
        [JsonProperty(PropertyName = "segmentsMuxed")]
        public int? SegmentsMuxed { get; internal set; }
    }
}
