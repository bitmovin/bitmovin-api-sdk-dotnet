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
    /// ProgressiveTsMuxing
    /// </summary>
    public class ProgressiveTsMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "PROGRESSIVE_TS";

        /// <summary>
        /// Length of the segments in seconds
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }

        /// <summary>
        /// Name of the output file
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Offset of MPEG-TS timestamps in seconds. e.g. first packet will start with PTS 900,000 for a 10 seconds offset (90,000 MPEG-TS timescale).
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; set; }
    }
}
