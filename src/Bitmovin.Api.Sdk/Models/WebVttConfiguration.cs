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
    /// WebVttConfiguration
    /// </summary>
    public class WebVttConfiguration : SubtitleConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "WEBVTT";
#pragma warning restore CS0414

        /// <summary>
        /// If set to true, the hours section on webvtt timestamp values will explicitely have zeroes instead of being omitted for values where hours &#x3D; 0.
        /// </summary>
        [JsonProperty(PropertyName = "appendOptionalZeroHour")]
        public bool? AppendOptionalZeroHour { get; set; }

        /// <summary>
        /// If set to true, the region information of the resulting webvtt file will be omitted. Defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreRegion")]
        public bool? IgnoreRegion { get; set; }

        /// <summary>
        /// CueIdentifierPolicy
        /// </summary>
        [JsonProperty(PropertyName = "cueIdentifierPolicy")]
        public WebVttCueIdentifierPolicy? CueIdentifierPolicy { get; set; }

        /// <summary>
        /// Styling
        /// </summary>
        [JsonProperty(PropertyName = "styling")]
        public WebVttStyling Styling { get; set; }
    }
}
