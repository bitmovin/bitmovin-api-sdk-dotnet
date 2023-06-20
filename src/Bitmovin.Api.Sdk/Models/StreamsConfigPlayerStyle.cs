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
    /// Player style config
    /// </summary>
    public class StreamsConfigPlayerStyle
    {
        /// <summary>
        /// Playback marker background color
        /// </summary>
        [JsonProperty(PropertyName = "playbackMarkerBgColor")]
        public string PlaybackMarkerBgColor { get; set; }

        /// <summary>
        /// Playback marker border color
        /// </summary>
        [JsonProperty(PropertyName = "playbackMarkerBorderColor")]
        public string PlaybackMarkerBorderColor { get; set; }

        /// <summary>
        /// Playback track played color
        /// </summary>
        [JsonProperty(PropertyName = "playbackTrackPlayedColor")]
        public string PlaybackTrackPlayedColor { get; set; }

        /// <summary>
        /// Playback track buffered color
        /// </summary>
        [JsonProperty(PropertyName = "playbackTrackBufferedColor")]
        public string PlaybackTrackBufferedColor { get; set; }

        /// <summary>
        /// Playback track background color
        /// </summary>
        [JsonProperty(PropertyName = "playbackTrackBgColor")]
        public string PlaybackTrackBgColor { get; set; }

        /// <summary>
        /// Text color
        /// </summary>
        [JsonProperty(PropertyName = "textColor")]
        public string TextColor { get; set; }

        /// <summary>
        /// Background color
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; }
    }
}
