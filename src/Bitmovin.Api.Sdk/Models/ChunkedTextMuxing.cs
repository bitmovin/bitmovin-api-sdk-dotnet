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
    /// ChunkedTextMuxing
    /// </summary>
    public class ChunkedTextMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "CHUNKED_TEXT";
#pragma warning restore CS0414

        /// <summary>
        /// Length of the segments in seconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }

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
        /// Offset of MPEG-TS timestamps in seconds. This only affects streams with [WebVttConfiguration](#/Encoding/PostEncodingConfigurationsSubtitlesWebVtt). If set, the X-TIMESTAMP-MAP will be added as described in the [HLS specification](https://datatracker.ietf.org/doc/html/rfc8216#section-3.5). For example, if set to 10 seconds, *X-TIMESTAMP-MAP&#x3D;MPEGTS:900000,LOCAL:00:00:00.000* will be added after each *WEBVTT* header. The default for ChunkedTextMuxing is that the X-TIMESTAMP-MAP will not be written. Important to note is that the default for &#x60;startOffset&#x60; for [TsMuxings](#/Encoding/PostEncodingEncodingsMuxingsTsByEncodingId) and [ProgressiveTsMuxings](#/Encoding/PostEncodingEncodingsMuxingsProgressiveTsByEncodingId) is 10 seconds. If the output of this muxing is used for HLS together with video/audio streams using TsMuxings and ProgressiveTsMuxings, this value should be set to the same &#x60;startOffset&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; set; }

        /// <summary>
        /// Number of segments which have been encoded
        /// </summary>
        [JsonProperty(PropertyName = "segmentsMuxed")]
        public int? SegmentsMuxed { get; internal set; }
    }
}
