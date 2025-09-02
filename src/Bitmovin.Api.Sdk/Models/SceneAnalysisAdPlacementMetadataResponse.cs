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
    /// SceneAnalysisAdPlacementMetadataResponse
    /// </summary>
    public class SceneAnalysisAdPlacementMetadataResponse
    {
        /// <summary>
        /// PlacedAds
        /// </summary>
        [JsonProperty(PropertyName = "placedAds")]
        public List<AdPosition> PlacedAds { get; set; } = new List<AdPosition>();

        /// <summary>
        /// AutomaticAdPlacement
        /// </summary>
        [JsonProperty(PropertyName = "automaticAdPlacement")]
        public AiSceneAnalysisAutomaticAdPlacement AutomaticAdPlacement { get; set; }
    }
}
