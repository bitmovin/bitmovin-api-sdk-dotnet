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
    /// HlsInput
    /// </summary>
    public class HlsInput : Input
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "HLS";
#pragma warning restore CS0414

        /// <summary>
        /// URL of HLS input
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Specifies the source for ad markers messages: - MANIFEST: Ad marker messages are read from tags in the HLS manifest - SEGMENTS: Ad marker messages are read from the content segments from the data stream 
        /// </summary>
        [JsonProperty(PropertyName = "adMarkersSource")]
        public AdMarkersSource? AdMarkersSource { get; set; }
    }
}
