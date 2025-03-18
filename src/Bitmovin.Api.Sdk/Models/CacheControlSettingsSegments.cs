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
    /// CacheControlSettingsSegments
    /// </summary>
    public class CacheControlSettingsSegments
    {
        /// <summary>
        /// Cache control settings for init segment.
        /// </summary>
        [JsonProperty(PropertyName = "initSegment")]
        public CacheControl InitSegment { get; set; }

        /// <summary>
        /// Cache control settings for media segment.
        /// </summary>
        [JsonProperty(PropertyName = "mediaSegment")]
        public CacheControl MediaSegment { get; set; }
    }
}
