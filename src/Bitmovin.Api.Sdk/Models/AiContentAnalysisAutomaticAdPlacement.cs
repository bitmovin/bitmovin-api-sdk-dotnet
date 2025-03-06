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
    /// AiContentAnalysisAutomaticAdPlacement
    /// </summary>
    public class AiContentAnalysisAutomaticAdPlacement
    {
        /// <summary>
        /// Ad placements schedule 
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public List<AutomaticAdPlacementPosition> Schedule { get; set; } = new List<AutomaticAdPlacementPosition>();
    }
}
