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
    /// Ad placement results for an encoding.
    /// </summary>
    public class SceneAnalysisAdPlacementMetadataResponse
    {
        /// <summary>
        /// Ad breaks selected for this encoding. Empty or omitted when none were selected.
        /// </summary>
        [JsonProperty(PropertyName = "placedAds")]
        public List<AdPosition> PlacedAds { get; set; } = new List<AdPosition>();

        /// <summary>
        /// Placement settings for this encoding. The schedule includes only entries that produced an ad break, with their requested positions.
        /// </summary>
        [JsonProperty(PropertyName = "automaticAdPlacement")]
        public AiSceneAnalysisAutomaticAdPlacement AutomaticAdPlacement { get; set; }
    }
}
