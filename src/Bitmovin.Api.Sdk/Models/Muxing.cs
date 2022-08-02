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
    /// Muxing
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(Fmp4Muxing), "FMP4")]
    [JsonSubtypes.KnownSubType(typeof(CmafMuxing), "CMAF")]
    [JsonSubtypes.KnownSubType(typeof(Mp4Muxing), "MP4")]
    [JsonSubtypes.KnownSubType(typeof(TsMuxing), "TS")]
    [JsonSubtypes.KnownSubType(typeof(WebmMuxing), "WEBM")]
    [JsonSubtypes.KnownSubType(typeof(Mp3Muxing), "MP3")]
    [JsonSubtypes.KnownSubType(typeof(MxfMuxing), "MXF")]
    [JsonSubtypes.KnownSubType(typeof(ProgressiveWebmMuxing), "PROGRESSIVE_WEBM")]
    [JsonSubtypes.KnownSubType(typeof(ProgressiveMovMuxing), "PROGRESSIVE_MOV")]
    [JsonSubtypes.KnownSubType(typeof(ProgressiveTsMuxing), "PROGRESSIVE_TS")]
    [JsonSubtypes.KnownSubType(typeof(BroadcastTsMuxing), "BROADCAST_TS")]
    [JsonSubtypes.KnownSubType(typeof(ChunkedTextMuxing), "CHUNKED_TEXT")]
    [JsonSubtypes.KnownSubType(typeof(TextMuxing), "TEXT")]
    [JsonSubtypes.KnownSubType(typeof(SegmentedRawMuxing), "SEGMENTED_RAW")]
    [JsonSubtypes.KnownSubType(typeof(PackedAudioMuxing), "PACKED_AUDIO")]

    public class Muxing : BitmovinResource
    {
        /// <summary>
        /// Streams
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public List<MuxingStream> Streams { get; set; } = new List<MuxingStream>();

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();

        /// <summary>
        /// Average bitrate. Available after encoding finishes.
        /// </summary>
        [JsonProperty(PropertyName = "avgBitrate")]
        public long? AvgBitrate { get; internal set; }

        /// <summary>
        /// Min bitrate. Available after encoding finishes.
        /// </summary>
        [JsonProperty(PropertyName = "minBitrate")]
        public long? MinBitrate { get; internal set; }

        /// <summary>
        /// Max bitrate. Available after encoding finishes.
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrate")]
        public long? MaxBitrate { get; internal set; }

        /// <summary>
        /// This read-only property is set during the analysis step of the encoding. If it contains items, the Muxing has been ignored during the encoding process according to its &#39;streamConditionsMode&#39;
        /// </summary>
        [JsonProperty(PropertyName = "ignoredBy")]
        public List<Ignoring> IgnoredBy { get; internal set; } = new List<Ignoring>();

        /// <summary>
        /// Specifies how to proceed with the Muxing when some of its Streams are ignored (see &#39;condition&#39; property of the Stream resource). The settings only make a difference for Muxings with more than one Stream. When retrieving the resource after the analysis step of the encoding has finished, &#39;ignoredBy&#39; will indicate if and why it has been ignored.
        /// </summary>
        [JsonProperty(PropertyName = "streamConditionsMode")]
        public StreamConditionsMode? StreamConditionsMode { get; set; }
    }
}
