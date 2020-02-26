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
    /// ClosedCaptionsMediaInfo
    /// </summary>
    public class ClosedCaptionsMediaInfo : SegmentsMediaInfo
    {
        /// <summary>
        /// Specifies a Rendition within the segments in the Media Playlist. (See HLS spec 4.3.4.1. EXT-X-MEDIA INSTREAM-ID) (required)
        /// </summary>
        [JsonProperty(PropertyName = "instreamId")]
        public string InstreamId { get; set; }

        /// <summary>
        /// A value of true indicates that the Rendition contains content which is considered essential to play.
        /// </summary>
        [JsonProperty(PropertyName = "forced")]
        public bool? Forced { get; set; }
    }
}
