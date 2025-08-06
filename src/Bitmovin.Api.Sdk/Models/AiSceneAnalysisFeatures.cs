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
    /// AiSceneAnalysisFeatures
    /// </summary>
    public class AiSceneAnalysisFeatures
    {
        /// <summary>
        /// AI scene analysis will create an asset description file. 
        /// </summary>
        [JsonProperty(PropertyName = "assetDescription")]
        public AiSceneAnalysisAssetDescription AssetDescription { get; set; }

        /// <summary>
        /// Ad markers placed on detected scene changes and configured positions. 
        /// </summary>
        [JsonProperty(PropertyName = "automaticAdPlacement")]
        public AiSceneAnalysisAutomaticAdPlacement AutomaticAdPlacement { get; set; }

        /// <summary>
        /// AI scene analysis will create translated asset description files for the language codes. 
        /// </summary>
        [JsonProperty(PropertyName = "outputLanguageCodes")]
        public AiSceneAnalysisOutputLanguageCodes OutputLanguageCodes { get; set; }
    }
}
