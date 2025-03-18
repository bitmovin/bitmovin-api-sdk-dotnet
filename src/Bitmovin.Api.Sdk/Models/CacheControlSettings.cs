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
    /// CacheControlSettings
    /// </summary>
    public class CacheControlSettings
    {
        /// <summary>
        /// Cache control settings for HLS manifest.
        /// </summary>
        [JsonProperty(PropertyName = "hls")]
        public CacheControlSettingsHls Hls { get; set; }

        /// <summary>
        /// Cache control settings for DASH manifest.
        /// </summary>
        [JsonProperty(PropertyName = "dash")]
        public CacheControlSettingsDash Dash { get; set; }

        /// <summary>
        /// Cache control settings for segments.
        /// </summary>
        [JsonProperty(PropertyName = "segments")]
        public CacheControlSettingsSegments Segments { get; set; }
    }
}
