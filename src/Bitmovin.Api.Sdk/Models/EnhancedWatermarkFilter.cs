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
        /// URL of the file to be used as watermark image. Supported image formats: PNG, JPEG, BMP, GIF (required)
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
        public PositionUnit? Unit { get; set; }
        
        /// <summary>
        /// Opacity to apply on the watermark image. Valid values are from 0.0 (completely transparent) to 1.0 (not transparent at all)
        /// </summary>
        [JsonProperty(PropertyName = "opacity")]
        public double? Opacity { get; set; }
        
        /// <summary>
        /// Desired width of the watermark image, the unit of the parameter is specified separately by the parameter &#39;unit&#39;. If both width and height are set the watermark size is fixed. If only one is set the aspect ratio of the image will be used to rescale it
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public double? Width { get; set; }
        
        /// <summary>
        /// Desired height of the watermark image, the unit of the parameter is specified separately by the parameter &#39;unit&#39;. If both width and height are set the watermark size is fixed. If only one is set the aspect ratio of the image will be used to rescale it
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public double? Height { get; set; }
    }

}
