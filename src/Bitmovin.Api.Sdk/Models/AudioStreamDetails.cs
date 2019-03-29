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
    /// AudioStreamDetails
    /// </summary>

    public class AudioStreamDetails : StreamDetails
    {
        /// <summary>
        /// SampleRate
        /// </summary>
        [JsonProperty(PropertyName = "sampleRate")]
        public int? SampleRate { get; set; }
        
        /// <summary>
        /// Bitrate
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public int? Bitrate { get; set; }
        
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
