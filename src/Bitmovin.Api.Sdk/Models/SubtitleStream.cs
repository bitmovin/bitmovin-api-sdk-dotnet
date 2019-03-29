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
    /// SubtitleStream
    /// </summary>

    public class SubtitleStream : MediaStream
    {
        /// <summary>
        /// Language of the stream
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        /// <summary>
        /// Hearing impaired support
        /// </summary>
        [JsonProperty(PropertyName = "hearingImpaired")]
        public bool? HearingImpaired { get; set; }
    }

}
