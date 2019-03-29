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
    /// SubtitleStreamDetails
    /// </summary>

    public class SubtitleStreamDetails : StreamDetails
    {
        /// <summary>
        /// Language
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        /// <summary>
        /// HearingImpaired
        /// </summary>
        [JsonProperty(PropertyName = "hearingImpaired")]
        public bool? HearingImpaired { get; set; }
    }

}
