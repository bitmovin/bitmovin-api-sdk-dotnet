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
    /// The configuration for the DTS:X
    /// </summary>
    public class DtsXAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DTSX";
#pragma warning restore CS0414

        /// <summary>
        /// ChannelLayout
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public DtsXChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// Loudness relative to full scale (K-weighted).
        /// </summary>
        [JsonProperty(PropertyName = "lkfsValue")]
        public double? LkfsValue { get; set; }

        /// <summary>
        /// OttLoudnessMode
        /// </summary>
        [JsonProperty(PropertyName = "ottLoudnessMode")]
        public OttLoudnessMode? OttLoudnessMode { get; set; }

        /// <summary>
        /// Specifies the sync interval which ranges from 1 to 10
        /// </summary>
        [JsonProperty(PropertyName = "syncInterval")]
        public long? SyncInterval { get; set; }
    }
}
