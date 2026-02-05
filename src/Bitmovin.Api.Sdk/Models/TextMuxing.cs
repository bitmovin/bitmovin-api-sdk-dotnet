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
    /// TextMuxing
    /// </summary>
    public class TextMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "TEXT";
#pragma warning restore CS0414

        /// <summary>
        /// Name of the output file (required)
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Offset of MPEG-TS timestamps in seconds. This only affects streams with [WebVttConfiguration](#/Encoding/PostEncodingConfigurationsSubtitlesWebVtt). If set, the X-TIMESTAMP-MAP will be added as described in the [HLS specification](https://datatracker.ietf.org/doc/html/rfc8216#section-3.5). For example, if set to 10 seconds, *X-TIMESTAMP-MAP&#x3D;MPEGTS:900000,LOCAL:00:00:00.000* will be added after each *WEBVTT* header. The default for TextMuxing is that the X-TIMESTAMP-MAP will not be written. Important to note is that the default for &#x60;startOffset&#x60; for [TsMuxings](#/Encoding/PostEncodingEncodingsMuxingsTsByEncodingId) and [ProgressiveTsMuxings](#/Encoding/PostEncodingEncodingsMuxingsProgressiveTsByEncodingId) is 10 seconds. If the output of this muxing is used for HLS together with video/audio streams using TsMuxings and ProgressiveTsMuxings, this value should be set to the same &#x60;startOffset&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; set; }
    }
}
