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
    /// UnsharpFilter
    /// </summary>

    public class UnsharpFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "UNSHARP";

        /// <summary>
        /// Must be an odd integer between 3 and 23
        /// </summary>
        [JsonProperty(PropertyName = "lumaMatrixHorizontalSize")]
        public int? LumaMatrixHorizontalSize { get; set; }
        
        /// <summary>
        /// Must be an odd integer between 3 and 23
        /// </summary>
        [JsonProperty(PropertyName = "lumaMatrixVerticalSize")]
        public int? LumaMatrixVerticalSize { get; set; }
        
        /// <summary>
        /// Negative value: blur, positive value: sharpen, floating point number, valid value range: -1.5 - 1.5
        /// </summary>
        [JsonProperty(PropertyName = "lumaEffectStrength")]
        public double? LumaEffectStrength { get; set; }
        
        /// <summary>
        /// Must be an odd integer between 3 and 23
        /// </summary>
        [JsonProperty(PropertyName = "chromaMatrixHorizontalSize")]
        public int? ChromaMatrixHorizontalSize { get; set; }
        
        /// <summary>
        /// Must be an odd integer between 3 and 23
        /// </summary>
        [JsonProperty(PropertyName = "chromaMatrixVerticalSize")]
        public int? ChromaMatrixVerticalSize { get; set; }
        
        /// <summary>
        /// Negative value: blur, positive value: sharpen, floating point number, valid value range: -1.5 - 1.5
        /// </summary>
        [JsonProperty(PropertyName = "chromaEffectStrength")]
        public double? ChromaEffectStrength { get; set; }
    }

}
