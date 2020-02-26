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
    /// MediaStream
    /// </summary>
    public class MediaStream : BitmovinResponse
    {
        /// <summary>
        /// Position starts from 0 and indicates the position of the stream in the media. 0 means that this is the first stream found in the media
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }

        /// <summary>
        /// Duration of the stream in seconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Codec of the stream
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }
    }
}
