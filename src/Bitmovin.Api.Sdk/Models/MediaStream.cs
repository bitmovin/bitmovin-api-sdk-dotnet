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
        /// Position of the stream in the media, starting from 0.
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
