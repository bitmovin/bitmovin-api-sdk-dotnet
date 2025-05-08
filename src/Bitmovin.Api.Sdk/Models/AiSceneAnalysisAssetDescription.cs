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
        /// Name of the output json file
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();
    }
}
