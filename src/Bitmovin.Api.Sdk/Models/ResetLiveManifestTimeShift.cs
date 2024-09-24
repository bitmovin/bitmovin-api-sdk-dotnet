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
        /// Determines how many seconds will be left in the manifest after segments are removed. If this is not set, all but one segment will be removed. 
        /// </summary>
        [JsonProperty(PropertyName = "residualPeriodInSeconds")]
        public double? ResidualPeriodInSeconds { get; set; }

        /// <summary>
        /// Offset in seconds from the start of the live event, defining the point from which all segments within that duration will be removed from the given manifests. E.g.: The segment length is 2 seconds and a timeshift of 120 seconds (2 minutes) is configured.  The manifest contains 60 segments with the last segment number being 80 (&#x60;segment_80.ts&#x60;).  This means the manifest contains &#x60;segment_20.ts&#x60; to &#x60;segment_80.ts&#x60; (timeshift of 2 minutes equals 60 segments in manifest) If you set &#x60;offsetInSeconds&#x60; to &#x60;120&#x60;, all segments below segment number 60 (&#x60;segment_60.ts&#x60;) will be removed. (&#x60;targetSegmentNumber &#x3D; offsetInSeconds / segmentLength&#x60;) The manifests will then contain &#x60;segment_60.ts&#x60; to &#x60;segment_80.ts&#x60; *Note:* Only &#x60;offsetInSeconds&#x60; or &#x60;residualPeriodInSeconds&#x60; can be set. 
        /// </summary>
        [JsonProperty(PropertyName = "offsetInSeconds")]
        public double? OffsetInSeconds { get; set; }

        /// <summary>
        /// The ids of the manifests to update. If this property is not set, all manifests tied to the encoding are updated.
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
