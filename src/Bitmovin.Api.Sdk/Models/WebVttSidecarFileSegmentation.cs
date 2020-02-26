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
    /// The segmenting configuration for this WebVTT sidecar file. If this is set, the given vtt file will be chunked.
    /// </summary>
    public class WebVttSidecarFileSegmentation
    {
        /// <summary>
        /// The length of the WebVTT fragments in seconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }
    }
}
