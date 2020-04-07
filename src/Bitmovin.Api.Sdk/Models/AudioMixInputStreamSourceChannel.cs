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
    /// AudioMixInputStreamSourceChannel
    /// </summary>
    public class AudioMixInputStreamSourceChannel
    {
        /// <summary>
        /// Gain for this source channel. Default is 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "gain")]
        public double? Gain { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AudioMixSourceChannelType? Type { get; set; }

        /// <summary>
        /// Number of this source channel. If type is &#39;CHANNEL_NUMBER&#39;, this must be set.
        /// </summary>
        [JsonProperty(PropertyName = "channelNumber")]
        public int? ChannelNumber { get; set; }
    }
}
