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
    /// AiContentAnalysis
    /// </summary>
    public class AiContentAnalysis
    {
        /// <summary>
        /// AI service settings
        /// </summary>
        [JsonProperty(PropertyName = "aiService")]
        public AiService AiService { get; set; }

        /// <summary>
        /// Features of the AI content analysis
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public AiContentAnalysisFeatures Features { get; set; }
    }
}
