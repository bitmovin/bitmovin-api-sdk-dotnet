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
    /// AiSceneAnalysisRegulatoryAdvisories
    /// </summary>
    public class AiSceneAnalysisRegulatoryAdvisories
    {
        /// <summary>
        /// The regulatory advisory topics to screen the asset for. At least one topic must be set. (required)
        /// </summary>
        [JsonProperty(PropertyName = "topics")]
        public List<RegulatoryAdvisoryTopic> Topics { get; set; } = new List<RegulatoryAdvisoryTopic>();
    }
}
