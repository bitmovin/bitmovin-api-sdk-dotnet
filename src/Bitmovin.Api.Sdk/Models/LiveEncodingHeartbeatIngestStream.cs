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
    /// Details about an individual stream within the live ingest.
    /// </summary>
    public class LiveEncodingHeartbeatIngestStream
    {
        /// <summary>
        /// Unique identifier of the stream.
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }

        /// <summary>
        /// Media type for the stream (e.g., \&quot;video\&quot; or \&quot;audio\&quot;).
        /// </summary>
        [JsonProperty(PropertyName = "mediaType")]
        public string MediaType { get; set; }

        /// <summary>
        /// Width of the video stream in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the video stream in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Frame rate of the video stream.
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Codec of the stream.
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// Aspect ratio of the video.
        /// </summary>
        [JsonProperty(PropertyName = "aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Container format&#39;s bitrate of the stream, in bits per second.
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Average number of samples/frames read per second.
        /// </summary>
        [JsonProperty(PropertyName = "samplesReadPerSecondAvg")]
        public double? SamplesReadPerSecondAvg { get; set; }

        /// <summary>
        /// Incoming bitrate measured in bits per second.
        /// </summary>
        [JsonProperty(PropertyName = "incomingBitrate")]
        public double? IncomingBitrate { get; set; }

        /// <summary>
        /// Largest encountered key-frame interval in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "keyFrameIntervalMax")]
        public int? KeyFrameIntervalMax { get; set; }

        /// <summary>
        /// Average key-frame interval in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "keyFrameIntervalAvg")]
        public double? KeyFrameIntervalAvg { get; set; }

        /// <summary>
        /// Last presentation timestamp (PTS) of the stream.
        /// </summary>
        [JsonProperty(PropertyName = "lastTimestamp")]
        public int? LastTimestamp { get; set; }

        /// <summary>
        /// Timescale of lastTimestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastTimestampTimescale")]
        public int? LastTimestampTimescale { get; set; }

        /// <summary>
        /// Number of audio channels.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfAudioChannels")]
        public int? NumberOfAudioChannels { get; set; }

        /// <summary>
        /// Format of the audio channel.
        /// </summary>
        [JsonProperty(PropertyName = "audioChannelFormat")]
        public string AudioChannelFormat { get; set; }

        /// <summary>
        /// lastArrivalTime timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "lastArrivalTime")]
        public DateTime? LastArrivalTime { get; set; }

        /// <summary>
        /// Indicates whether this particular stream is healthy.
        /// </summary>
        [JsonProperty(PropertyName = "healthy")]
        public bool? Healthy { get; set; }
    }
}
