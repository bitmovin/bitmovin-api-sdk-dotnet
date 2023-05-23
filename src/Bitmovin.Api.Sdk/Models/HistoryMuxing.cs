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
    /// HistoryMuxing
    /// </summary>
    public class HistoryMuxing
    {
        /// <summary>
        /// Muxing
        /// </summary>
        [JsonProperty(PropertyName = "muxing")]
        public Muxing Muxing { get; set; }

        /// <summary>
        /// Drms
        /// </summary>
        [JsonProperty(PropertyName = "drms")]
        public List<Drm> Drms { get; set; } = new List<Drm>();

        /// <summary>
        /// BroadcastTsMuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "broadcastTsMuxingInformation")]
        public BroadcastTsMuxingInformation BroadcastTsMuxingInformation { get; set; }

        /// <summary>
        /// Fmp4MuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "fmp4MuxingInformation")]
        public Fmp4MuxingInformation Fmp4MuxingInformation { get; set; }

        /// <summary>
        /// Mp3MuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "mp3MuxingInformation")]
        public Mp3MuxingInformation Mp3MuxingInformation { get; set; }

        /// <summary>
        /// Mp4MuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "mp4MuxingInformation")]
        public Mp4MuxingInformation Mp4MuxingInformation { get; set; }

        /// <summary>
        /// PackedAudioMuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "packedAudioMuxingInformation")]
        public PackedAudioMuxingInformation PackedAudioMuxingInformation { get; set; }

        /// <summary>
        /// ProgressiveMovMuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "progressiveMovMuxingInformation")]
        public ProgressiveMovMuxingInformation ProgressiveMovMuxingInformation { get; set; }

        /// <summary>
        /// ProgressiveTsMuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "progressiveTsMuxingInformation")]
        public ProgressiveTsMuxingInformation ProgressiveTsMuxingInformation { get; set; }

        /// <summary>
        /// ProgressiveWebmMuxingInformation
        /// </summary>
        [JsonProperty(PropertyName = "progressiveWebmMuxingInformation")]
        public ProgressiveWebmMuxingInformation ProgressiveWebmMuxingInformation { get; set; }
    }
}
