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
    /// A subject or object identified in a shot. Positions describe sampled appearances, not continuous tracking.
    /// </summary>
    public class MainSubject
    {
        /// <summary>
        /// Category of the subject, usually an Open Images V7 class name such as Person or Vehicle. Other values can occur. Retains its original value in language-specific results. (required)
        /// </summary>
        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        /// <summary>
        /// A detailed textual description of the subject&#39;s appearance and characteristics (required)
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Time in seconds from the start of this shot when the subject first appears. (required)
        /// </summary>
        [JsonProperty(PropertyName = "appearanceTimeInSeconds")]
        public double? AppearanceTimeInSeconds { get; set; }

        /// <summary>
        /// The horizontal center position of the subject as a percentage from the left edge (0-100, where 0 is the left edge and 100 is the right edge) (required)
        /// </summary>
        [JsonProperty(PropertyName = "centerX")]
        public double? CenterX { get; set; }

        /// <summary>
        /// The vertical center position of the subject as a percentage from the top edge (0-100, where 0 is the top edge and 100 is the bottom edge) (required)
        /// </summary>
        [JsonProperty(PropertyName = "centerY")]
        public double? CenterY { get; set; }

        /// <summary>
        /// Bounding box at the subject&#39;s sampled appearance, in [ymin, xmin, ymax, xmax] order. Coordinates use a 0-1000 scale with a top-left origin, normalized independently against the full frame height and width. Omitted when no bounding box is available; the center coordinates remain valid.
        /// </summary>
        [JsonProperty(PropertyName = "box2d")]
        public List<int?> Box2d { get; set; } = new List<int?>();
    }
}
