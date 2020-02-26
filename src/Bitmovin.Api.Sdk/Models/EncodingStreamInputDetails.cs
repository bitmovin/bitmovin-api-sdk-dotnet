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
    /// EncodingStreamInputDetails
    /// </summary>
    public class EncodingStreamInputDetails
    {
        /// <summary>
        /// Format name
        /// </summary>
        [JsonProperty(PropertyName = "formatName")]
        public string FormatName { get; internal set; }

        /// <summary>
        /// The start time in seconds
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public double? StartTime { get; internal set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; internal set; }

        /// <summary>
        /// Input file size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; internal set; }

        /// <summary>
        /// Bitrate in bps
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; internal set; }

        /// <summary>
        /// Additional metadata saved in the input file
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public Dictionary<string, Object> Tags { get; set; } = new Dictionary<string, Object>();

        /// <summary>
        /// Video streams in the input file
        /// </summary>
        [JsonProperty(PropertyName = "videoStreams")]
        public List<VideoStream> VideoStreams { get; internal set; } = new List<VideoStream>();

        /// <summary>
        /// Audio stream in the input file
        /// </summary>
        [JsonProperty(PropertyName = "audioStreams")]
        public List<AudioStream> AudioStreams { get; internal set; } = new List<AudioStream>();

        /// <summary>
        /// Meta data streams in the input file
        /// </summary>
        [JsonProperty(PropertyName = "metaStreams")]
        public List<MediaStream> MetaStreams { get; internal set; } = new List<MediaStream>();

        /// <summary>
        /// Subtitle streams in the input file
        /// </summary>
        [JsonProperty(PropertyName = "subtitleStreams")]
        public List<SubtitleStream> SubtitleStreams { get; internal set; } = new List<SubtitleStream>();
    }
}
