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
    /// Cea608708SubtitleConfiguration
    /// </summary>

    public class Cea608708SubtitleConfiguration
    {
        /// <summary>
        /// If enabled, CEA 608 an CEA 708 subtitles will be copied from the input video stream to the output video stream. Note: This does not work, if the output framerate is different than the input framerate (except doubling the framerate with deinterlacing per field)
        /// </summary>
        [JsonProperty(PropertyName = "passthroughActivated")]
        public bool? PassthroughActivated { get; set; }
    }

}
