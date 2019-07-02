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
    /// CropFilter
    /// </summary>

    public class CropFilter : Filter
    {
        /// <summary>
        /// Amount of pixels which will be cropped of the input video from the left side.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public int? Left { get; set; }
        
        /// <summary>
        /// Amount of pixels which will be cropped of the input video from the right side.
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public int? Right { get; set; }
        
        /// <summary>
        /// Amount of pixels which will be cropped of the input video from the top.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }
        
        /// <summary>
        /// Amount of pixels which will be cropped of the input video from the bottom.
        /// </summary>
        [JsonProperty(PropertyName = "bottom")]
        public int? Bottom { get; set; }
        
        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public PositionUnit? Unit { get; set; }
    }

}
