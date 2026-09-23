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
    /// AiSceneAnalysisLiveRecordingRequest
    /// </summary>
    public class AiSceneAnalysisLiveRecordingRequest
    {
        /// <summary>
        /// Destinations for the stream recording (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<AiSceneAnalysisLiveOutput> Outputs { get; set; } = new List<AiSceneAnalysisLiveOutput>();
    }
}
