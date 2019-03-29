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
    /// ProgressiveTsMuxingInformationByteRanges
    /// </summary>

    public class ProgressiveTsMuxingInformationByteRanges
    {
        /// <summary>
        /// Number of the segment (starting at 0)
        /// </summary>
        [JsonProperty(PropertyName = "segmentNumber")]
        public int? SegmentNumber { get; set; }
        
        /// <summary>
        /// The position of the first byte of the segment
        /// </summary>
        [JsonProperty(PropertyName = "startBytes")]
        public long? StartBytes { get; set; }
        
        /// <summary>
        /// The position of the last byte of the segment
        /// </summary>
        [JsonProperty(PropertyName = "endBytes")]
        public long? EndBytes { get; set; }
        
        /// <summary>
        /// The duration of the segment in seconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
    }

}
