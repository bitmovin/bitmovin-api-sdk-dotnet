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
    /// StreamMetadata
    /// </summary>
    public class StreamMetadata
    {
        /// <summary>
        /// Language of the media contained in the stream. If the value is not set, then no metadata tag is set for the media stream.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
