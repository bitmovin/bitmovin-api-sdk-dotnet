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
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "CROP";
#pragma warning restore CS0414

        /// <summary>
        /// Amount of pixels that will be cropped of the input video from the left side. Must be zero or a positive value.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public int? Left { get; set; }

        /// <summary>
        /// Amount of pixels that will be cropped of the input video from the right side. Must be zero or a positive value.
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public int? Right { get; set; }

        /// <summary>
        /// Amount of pixels that will be cropped of the input video from the top. Must be zero or a positive value.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }

        /// <summary>
        /// Amount of pixels that will be cropped of the input video from the bottom. Must be zero or a positive value.
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
