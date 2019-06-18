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
    /// AudioStream
    /// </summary>

    public class AudioStream : MediaStream
    {
        /// <summary>
        /// Audio sampling rate in Hz
        /// </summary>
        [JsonProperty(PropertyName = "sampleRate")]
        public int? SampleRate { get; set; }
        
        /// <summary>
        /// Bitrate in bps
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public string Bitrate { get; set; }
        
        /// <summary>
        /// Bitrate in bps
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public long? Rate { get; set; }
        
        /// <summary>
        /// Audio channel format
        /// </summary>
        [JsonProperty(PropertyName = "channelFormat")]
        public string ChannelFormat { get; set; }
        
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
