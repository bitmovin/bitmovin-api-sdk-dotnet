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
    /// Represents a main subject or object detected within a shot, including its classification, spatial position, and appearance timing
    /// </summary>
    public class MainSubject
    {
        /// <summary>
        /// The category or type of the detected subject based on the YOLOv8 OIv7 (Open Images V7) object detection model (e.g., &#39;person&#39;, &#39;vehicle&#39;, &#39;building&#39;) (required)
        /// </summary>
        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        /// <summary>
        /// A detailed textual description of the subject&#39;s appearance and characteristics (required)
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The timestamp in seconds when this subject first appears or is most prominently visible in the shot (required)
        /// </summary>
        [JsonProperty(PropertyName = "appearanceTimeInSeconds")]
        public decimal? AppearanceTimeInSeconds { get; set; }

        /// <summary>
        /// The horizontal center position of the subject as a percentage from the left edge (0-100, where 0 is the left edge and 100 is the right edge) (required)
        /// </summary>
        [JsonProperty(PropertyName = "centerX")]
        public decimal? CenterX { get; set; }

        /// <summary>
        /// The vertical center position of the subject as a percentage from the top edge (0-100, where 0 is the top edge and 100 is the bottom edge) (required)
        /// </summary>
        [JsonProperty(PropertyName = "centerY")]
        public decimal? CenterY { get; set; }
    }
}
