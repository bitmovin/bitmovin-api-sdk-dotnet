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
    /// WatermarkFilter
    /// </summary>
    public class WatermarkFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "WATERMARK";
#pragma warning restore CS0414

        /// <summary>
        /// URL of the file to be used as watermark image. Supported image formats: PNG, JPEG, BMP, GIF (required)
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Distance from the left edge of the input video to the left edge of the watermark image. May not be set if &#39;right&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public int? Left { get; set; }

        /// <summary>
        /// Distance from the right edge of the input video to the right edge of the watermark image . May not be set if &#39;left&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public int? Right { get; set; }

        /// <summary>
        /// Distance from the top edge of the input video to the top edge of the watermark image. May not be set if &#39;bottom&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }

        /// <summary>
        /// Distance from the bottom edge of the input video to the bottom edge of the watermark image. May not be set if &#39;top&#39; is set.
        /// </summary>
        [JsonProperty(PropertyName = "bottom")]
        public int? Bottom { get; set; }

        /// <summary>
        /// Specifies if the values of &#39;left&#39;, &#39;right&#39;, &#39;top&#39; and &#39;bottom&#39; are interpreted as pixels or as a percentage of the input video&#39;s dimensions.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public PositionUnit? Unit { get; set; }
    }
}
