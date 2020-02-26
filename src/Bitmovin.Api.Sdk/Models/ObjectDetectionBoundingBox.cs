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
    /// ObjectDetectionBoundingBox
    /// </summary>
    public class ObjectDetectionBoundingBox
    {
        /// <summary>
        /// Horizontal position of the top left corner, given as a fraction of the frame width
        /// </summary>
        [JsonProperty(PropertyName = "topLeftX")]
        public double? TopLeftX { get; set; }

        /// <summary>
        /// Vertical position of the top left corner, given as a fraction of the frame height
        /// </summary>
        [JsonProperty(PropertyName = "topLeftY")]
        public double? TopLeftY { get; set; }

        /// <summary>
        /// Horizontal position of the bottom right corner, given as a fraction of the frame width
        /// </summary>
        [JsonProperty(PropertyName = "bottomRightX")]
        public double? BottomRightX { get; set; }

        /// <summary>
        /// Vertical position of the bottom right corner, given as a fraction of the frame height
        /// </summary>
        [JsonProperty(PropertyName = "bottomRightY")]
        public double? BottomRightY { get; set; }
    }
}
