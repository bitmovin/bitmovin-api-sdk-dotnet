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
    /// BroadcastTsMuxingConfiguration
    /// </summary>
    public class BroadcastTsMuxingConfiguration
    {
        /// <summary>
        /// Transport configuration details for the Broadcast TS muxing.
        /// </summary>
        [JsonProperty(PropertyName = "transport")]
        public BroadcastTsTransportConfiguration Transport { get; set; }

        /// <summary>
        /// Program configuration details for the Broadcast TS muxing.
        /// </summary>
        [JsonProperty(PropertyName = "program")]
        public BroadcastTsProgramConfiguration Program { get; set; }

        /// <summary>
        /// VideoStreams
        /// </summary>
        [JsonProperty(PropertyName = "videoStreams")]
        public List<BroadcastTsVideoInputStreamConfiguration> VideoStreams { get; set; } = new List<BroadcastTsVideoInputStreamConfiguration>();

        /// <summary>
        /// AudioStreams
        /// </summary>
        [JsonProperty(PropertyName = "audioStreams")]
        public List<BroadcastTsAudioInputStreamConfiguration> AudioStreams { get; set; } = new List<BroadcastTsAudioInputStreamConfiguration>();
    }
}
