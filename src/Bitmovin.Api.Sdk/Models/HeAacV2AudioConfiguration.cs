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
    /// HeAacV2AudioConfiguration
    /// </summary>
    public class HeAacV2AudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "HE_AAC_V2";

        /// <summary>
        /// Channel layout of the audio codec configuration
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public AacChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// Spectral Band Replication (SBR) and Parameteric Stereo (PS) signaling style.
        /// </summary>
        [JsonProperty(PropertyName = "signaling")]
        public HeAacV2Signaling? Signaling { get; set; }
    }
}
