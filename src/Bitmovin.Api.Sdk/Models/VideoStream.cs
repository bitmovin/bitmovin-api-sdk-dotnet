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
    /// VideoStream
    /// </summary>
    public class VideoStream : MediaStream
    {
        /// <summary>
        /// Frame rate of the video
        /// </summary>
        [JsonProperty(PropertyName = "fps")]
        public string Fps { get; set; }

        /// <summary>
        /// Bitrate in bps
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public string Bitrate { get; set; }

        /// <summary>
        /// Bitrate in bps (the same as bitrate, but represented as an integer value)
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public long? Rate { get; set; }

        /// <summary>
        /// Width of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the video (required)
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Pixel aspect ratio of the video. Default is 1.0
        /// </summary>
        [JsonProperty(PropertyName = "par")]
        public double? Par { get; set; }

        /// <summary>
        /// Rotation of the video for mobile devices. Default is 0.
        /// </summary>
        [JsonProperty(PropertyName = "rotation")]
        public int? Rotation { get; set; }
    }
}
