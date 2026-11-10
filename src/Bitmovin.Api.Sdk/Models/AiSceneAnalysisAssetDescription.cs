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
    /// AiSceneAnalysisAssetDescription
    /// </summary>
    public class AiSceneAnalysisAssetDescription
    {
        /// <summary>
        /// Name of the output JSON file. The [asset-description JSON Schema](https://storage.googleapis.com/ai-scene-analysis-demo-content/schemas/asset-description.schema.json) describes the structure of newly written original and translated files.
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Output destinations in which the generated asset-description JSON files are stored.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();
    }
}
