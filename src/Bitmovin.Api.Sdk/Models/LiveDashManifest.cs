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
    /// LiveDashManifest
    /// </summary>
    public class LiveDashManifest
    {
        /// <summary>
        /// Dash manifest id (required)
        /// </summary>
        [JsonProperty(PropertyName = "manifestId")]
        public string ManifestId { get; set; }

        /// <summary>
        /// Timeshift in seconds
        /// </summary>
        [JsonProperty(PropertyName = "timeshift")]
        public double? Timeshift { get; set; }

        /// <summary>
        /// Live edge offset in seconds. How it is applied depends on the type of the segmented representations in the manifest. For &#x60;TIMELINE&#x60; representations, new segments are held back for this duration (rounded up to whole segments) before they are added to the SegmentTimeline, and are always added in order. This adds the same amount of latency, but a segment that arrives late by up to this duration does not interrupt the manifest. A segment that arrives later than that stops the SegmentTimeline from updating until it arrives. If it does not arrive at all, a placeholder segment is added in its place once a few newer segments are available. If set to 0, segments are added as soon as they are available, still in order. For &#x60;TEMPLATE&#x60; representations, the &#x60;availabilityStartTime&#x60; is set this many seconds later, so players request each segment this much later. Late segments do not change the manifest; a player that requests a segment before it is uploaded gets an error. Segments are also kept in the manifest for this duration on top of the timeshift. We recommend a value of at least 2 segment durations. 
        /// </summary>
        [JsonProperty(PropertyName = "liveEdgeOffset")]
        public double? LiveEdgeOffset { get; set; }

        /// <summary>
        /// The suggestedPresentationDelay to be set in the DASH manifest. If nothing is set, no value will be set.
        /// </summary>
        [JsonProperty(PropertyName = "suggestedPresentationDelay")]
        public double? SuggestedPresentationDelay { get; set; }

        /// <summary>
        /// The minimumUpdatePeriod to be set in the DASH manifest. If nothing is set, the segment duration will be set.
        /// </summary>
        [JsonProperty(PropertyName = "minimumUpdatePeriod")]
        public double? MinimumUpdatePeriod { get; set; }

        /// <summary>
        /// The mode to trigger the availabilityStartTime initialization.
        /// </summary>
        [JsonProperty(PropertyName = "availabilityStartTimeMode")]
        public AvailabilityStartTimeMode? AvailabilityStartTimeMode { get; set; }

        /// <summary>
        /// AdMarkerSettings
        /// </summary>
        [JsonProperty(PropertyName = "adMarkerSettings")]
        public DashManifestAdMarkerSettings AdMarkerSettings { get; set; }
    }
}
