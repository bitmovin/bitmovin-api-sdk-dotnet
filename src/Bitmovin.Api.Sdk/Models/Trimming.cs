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
    /// Trimming
    /// </summary>
    public class Trimming
    {
        /// <summary>
        /// Defines the offset in seconds from which the encoding should start, beginning at 0.
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// Defines how many seconds from the input will be encoded. If not set, the input will be encoded until its end.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// When true, \&quot;duration\&quot; will be interpreted as a maximum and not cause an error if the input is too short
        /// </summary>
        [JsonProperty(PropertyName = "ignoreDurationIfInputTooShort")]
        public bool? IgnoreDurationIfInputTooShort { get; set; }

        /// <summary>
        /// Defines the H264 picture timing of the first frame from which the encoding should start. Any defined offset or duration in seconds will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "startPicTiming")]
        public string StartPicTiming { get; set; }

        /// <summary>
        /// Defines the H264 picture timing of the last frame, that will be included in the encoding. Any defined offset or duration in seconds will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "endPicTiming")]
        public string EndPicTiming { get; set; }
    }
}
