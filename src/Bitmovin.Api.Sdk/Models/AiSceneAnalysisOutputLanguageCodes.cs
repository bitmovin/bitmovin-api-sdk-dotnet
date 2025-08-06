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
    /// AiSceneAnalysisOutputLanguageCodes
    /// </summary>
    public class AiSceneAnalysisOutputLanguageCodes
    {
        /// <summary>
        /// OutputLanguageCodes
        /// </summary>
        [JsonProperty(PropertyName = "outputLanguageCodes")]
        public List<string> OutputLanguageCodes { get; set; } = new List<string>();
    }
}
