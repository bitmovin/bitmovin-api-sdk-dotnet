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
    /// TsMuxing
    /// </summary>
    public class TsMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "TS";

        /// <summary>
        /// Length of the fragments in seconds
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }

        /// <summary>
        /// Prevents creation of very short final segments (in seconds). If the last segment is shorter than minimumSegmentLength, it will be merged with the previous one, creating a segment of a size up to segmentLength + minimumSegmentLength.
        /// </summary>
        [JsonProperty(PropertyName = "minimumSegmentLength")]
        public double? MinimumSegmentLength { get; set; }

        /// <summary>
        /// Segment naming policy
        /// </summary>
        [JsonProperty(PropertyName = "segmentNaming")]
        public string SegmentNaming { get; set; }

        /// <summary>
        /// Segment naming policy containing one or both of the following placeholders: - &#39;{rand_chars:x}&#39;, which will be replaced by a random alphanumeric string of length x (default 32)   on each (re)start of the encoding. The resulting string will be copied to the segmentNaming property.   Intended to avoid re-use of segment names after restarting a live encoding. - &#39;{segment_rand_chars:x}&#39;, which will be replaced by a random alphanumeric string of length x (default 32)   for each different segment. This is intended to avoid guessing segment URLs by replacing segment numbers.  If segmentNamingTemplate is set, segmentNaming must not be set. 
        /// </summary>
        [JsonProperty(PropertyName = "segmentNamingTemplate")]
        public string SegmentNamingTemplate { get; set; }

        /// <summary>
        /// Offset of MPEG-TS timestamps in seconds. E.g., first packet will start with PTS 900,000 for a 10 seconds offset (90,000 MPEG-TS timescale).
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; set; }

        /// <summary>
        /// Number of segments which have been encoded
        /// </summary>
        [JsonProperty(PropertyName = "segmentsMuxed")]
        public int? SegmentsMuxed { get; internal set; }

        /// <summary>
        /// Advanced Configuration of the MPEG Transport Stream Parameters
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public TsMuxingConfiguration Configuration { get; set; }
    }
}
