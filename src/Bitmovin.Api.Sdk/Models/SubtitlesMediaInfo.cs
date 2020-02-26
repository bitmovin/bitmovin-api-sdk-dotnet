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
    /// SubtitlesMediaInfo
    /// </summary>
    public class SubtitlesMediaInfo : StandardMediaInfo
    {
        /// <summary>
        /// A value of true indicates that the Rendition contains content which is considered essential to play.
        /// </summary>
        [JsonProperty(PropertyName = "forced")]
        public bool? Forced { get; set; }
    }
}
