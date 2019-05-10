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
    /// CmafMuxing
    /// </summary>

    public class CmafMuxing : Muxing
    {
        /// <summary>
        /// Length of the fragments in seconds
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }
        
        /// <summary>
        /// Segment naming policy
        /// </summary>
        [JsonProperty(PropertyName = "segmentNaming")]
        public string SegmentNaming { get; set; }
        
        /// <summary>
        /// Segment naming policy containing a placeholder of the format &#39;{rand_chars:x}&#39;, which will be replaced by a random alphanumeric string of length x (default 32) on each (re)start of the encoding. The resulting string will be copied to the segmentNaming property. Intended to avoid re-use of segment names after restarting a live encoding. If segmentNamingTemplate is set, segmentNaming must not be set.
        /// </summary>
        [JsonProperty(PropertyName = "segmentNamingTemplate")]
        public string SegmentNamingTemplate { get; set; }
        
        /// <summary>
        /// Init segment name
        /// </summary>
        [JsonProperty(PropertyName = "initSegmentName")]
        public string InitSegmentName { get; set; }
        
        /// <summary>
        /// Segment naming policy containing a placeholder of the format &#39;{rand_chars:x}&#39;, which will be replaced by a random alphanumeric string of length x (default 32) on each (re)start of the encoding. The resulting string will be copied to the initSegmentName property. Intended to avoid re-use of segment names after restarting a live encoding. If initSegmentNameTemplate is set, initSegmentName must not be set.
        /// </summary>
        [JsonProperty(PropertyName = "initSegmentNameTemplate")]
        public string InitSegmentNameTemplate { get; set; }
        
        /// <summary>
        /// Number of segments which have been encoded
        /// </summary>
        [JsonProperty(PropertyName = "segmentsMuxed")]
        public int? SegmentsMuxed { get; internal set; }
        
        /// <summary>
        /// Number of media frames per CMAF chunk. Defaults to: Length of a segment in frames. Minimum: 1. Maximum: Length of a segment in frames.
        /// </summary>
        [JsonProperty(PropertyName = "framesPerCmafChunk")]
        public Object FramesPerCmafChunk { get; set; }
    }

}
