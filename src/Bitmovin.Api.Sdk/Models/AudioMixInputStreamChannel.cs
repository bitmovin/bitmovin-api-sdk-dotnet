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
    /// AudioMixInputStreamChannel
    /// </summary>

    public class AudioMixInputStreamChannel
    {
        /// <summary>
        /// The id of the input stream that should be used for mixing.
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }
        
        /// <summary>
        /// OutputChannelType
        /// </summary>
        [JsonProperty(PropertyName = "outputChannelType")]
        public AudioMixChannelType? OutputChannelType { get; set; }
        
        /// <summary>
        /// Number of this output channel. If type is &#39;CHANNEL_NUMBER&#39;, this must be set.
        /// </summary>
        [JsonProperty(PropertyName = "outputChannelNumber")]
        public int? OutputChannelNumber { get; set; }
    }

}
