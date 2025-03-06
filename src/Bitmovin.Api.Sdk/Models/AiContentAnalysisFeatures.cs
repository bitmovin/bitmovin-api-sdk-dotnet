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
    /// AiContentAnalysisFeatures
    /// </summary>
    public class AiContentAnalysisFeatures
    {
        /// <summary>
        /// AI content analysis will create an asset description file. 
        /// </summary>
        [JsonProperty(PropertyName = "assetDescription")]
        public AiContentAnalysisAssetDescription AssetDescription { get; set; }

        /// <summary>
        /// Ad markers placed on detected scene changes and configured positions. 
        /// </summary>
        [JsonProperty(PropertyName = "automaticAdPlacement")]
        public AiContentAnalysisAutomaticAdPlacement AutomaticAdPlacement { get; set; }
    }
}
