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
    /// AiSceneAnalysisLiveResultMetadata
    /// </summary>
    public class AiSceneAnalysisLiveResultMetadata
    {
        /// <summary>
        /// Version of the AI analysis software (required)
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Disclaimer associated with AI-generated analysis data (required)
        /// </summary>
        [JsonProperty(PropertyName = "disclaimer")]
        public string Disclaimer { get; set; }
    }
}
