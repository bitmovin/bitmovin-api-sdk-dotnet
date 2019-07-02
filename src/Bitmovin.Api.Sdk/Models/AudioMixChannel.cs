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
    /// AudioMixChannel
    /// </summary>

    public class AudioMixChannel
    {
        /// <summary>
        /// Channel number of this mix (starting with 0) (required)
        /// </summary>
        [JsonProperty(PropertyName = "channelNumber")]
        public int? ChannelNumber { get; set; }
        
        /// <summary>
        /// List of source channels to be mixed (required)
        /// </summary>
        [JsonProperty(PropertyName = "sourceChannels")]
        public List<SourceChannel> SourceChannels { get; set; } = new List<SourceChannel>();
    }

}
