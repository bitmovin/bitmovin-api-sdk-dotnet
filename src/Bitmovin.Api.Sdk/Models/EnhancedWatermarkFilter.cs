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
    /// EnhancedWatermarkFilter
    /// </summary>

    public class EnhancedWatermarkFilter : Filter
    {
        /// <summary>
        /// URL of the file to be used as watermark image. Supported image formats: PNG, JPEG, BMP, GIF
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
        /// <summary>
        /// Distance from the left edge of the input video to the left edge of the watermark image. May not be set if &#39;right&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public double? Left { get; set; }
        
        /// <summary>
        /// Distance from the right edge of the input video to the right edge of the watermark image . May not be set if &#39;left&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public double? Right { get; set; }
        
        /// <summary>
        /// Distance from the top edge of the input video to the top edge of the watermark image. May not be set if &#39;bottom&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public double? Top { get; set; }
        
        /// <summary>
        /// Distance from the bottom edge of the input video to the bottom edge of the watermark image. May not be set if &#39;top&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "bottom")]
        public double? Bottom { get; set; }
        
        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public PositionUnit Unit { get; set; }
        
        /// <summary>
        /// Opacity to apply on the watermark image. Valid values are from 0.0 (completely transparent) to 1.0 (not transparent at all)
        /// </summary>
        [JsonProperty(PropertyName = "opacity")]
        public double? Opacity { get; set; }
    }

}
