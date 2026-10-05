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
    /// ResetLiveManifestTimeShift
    /// </summary>
    public class ResetLiveManifestTimeShift : BitmovinResponse
    {
        /// <summary>
        /// Specifies how many seconds of content remain in the manifest after older segments are removed. At least one segment is always retained. If neither &#x60;residualPeriodInSeconds&#x60; nor &#x60;offsetInSeconds&#x60; is set, all segments except the most recent are removed. For DASH manifests that use SegmentTemplate, the retained duration also includes the value configured for &#x60;liveEdgeOffset&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "residualPeriodInSeconds")]
        public double? ResidualPeriodInSeconds { get; set; }

        /// <summary>
        /// Specifies an offset, in seconds, from the start of the live event. All segments before this position are removed from the affected manifests. For example, assume a segment length of 2 seconds and a configured &#x60;timeshift&#x60; of 120 seconds (2 minutes). If the most recent segment is &#x60;segment_80.ts&#x60;, the manifest contains 60 segments, from &#x60;segment_21.ts&#x60; through &#x60;segment_80.ts&#x60;. Setting &#x60;offsetInSeconds&#x60; to &#x60;120&#x60; sets the target segment number to 60 (&#x60;targetSegmentNumber &#x3D; offsetInSeconds / segmentLength&#x60;). All segments before &#x60;segment_60.ts&#x60; are removed. Each affected manifest then contains &#x60;segment_60.ts&#x60; through &#x60;segment_80.ts&#x60;.  *Note:* Do not set both &#x60;offsetInSeconds&#x60; and &#x60;residualPeriodInSeconds&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "offsetInSeconds")]
        public double? OffsetInSeconds { get; set; }

        /// <summary>
        /// The IDs of the manifests to update. If omitted, all supported manifests associated with the encoding are updated. HLS live manifests are supported. DASH live manifests require encoder version 2.235.0 or later.
        /// </summary>
        [JsonProperty(PropertyName = "manifestIds")]
        public List<string> ManifestIds { get; set; } = new List<string>();

        /// <summary>
        /// If set to true, the Progressive muxing start position will be shifted to the start of the first remaining segment after the removal.  NOTE: This only works for Progressive MP4 muxings.
        /// </summary>
        [JsonProperty(PropertyName = "shiftProgressiveMuxingStartPosition")]
        public bool? ShiftProgressiveMuxingStartPosition { get; set; }
    }
}
