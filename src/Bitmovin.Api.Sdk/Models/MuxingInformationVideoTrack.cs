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
    /// MuxingInformationVideoTrack
    /// </summary>

    public class MuxingInformationVideoTrack
    {
        /// <summary>
        /// The stream index in the container
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; internal set; }
        
        /// <summary>
        /// The codec used for the track
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; internal set; }
        
        /// <summary>
        /// The codec string of the track
        /// </summary>
        [JsonProperty(PropertyName = "codecIso")]
        public string CodecIso { get; internal set; }
        
        /// <summary>
        /// The bitrate of the video track
        /// </summary>
        [JsonProperty(PropertyName = "bitRate")]
        public long? BitRate { get; internal set; }
        
        /// <summary>
        /// TODO add description
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public long? Rate { get; internal set; }
        
        /// <summary>
        /// The pixel format used
        /// </summary>
        [JsonProperty(PropertyName = "pixelFormat")]
        public string PixelFormat { get; internal set; }
        
        /// <summary>
        /// The frame mode (e.g. progressive)
        /// </summary>
        [JsonProperty(PropertyName = "frameMode")]
        public string FrameMode { get; internal set; }
        
        /// <summary>
        /// The width of the frame in pixel
        /// </summary>
        [JsonProperty(PropertyName = "frameWidth")]
        public int? FrameWidth { get; internal set; }
        
        /// <summary>
        /// The height of the frame in pixel
        /// </summary>
        [JsonProperty(PropertyName = "frameHeight")]
        public int? FrameHeight { get; internal set; }
        
        /// <summary>
        /// The frame rate of the stream in fractional format
        /// </summary>
        [JsonProperty(PropertyName = "frameRate")]
        public string FrameRate { get; internal set; }
        
        /// <summary>
        /// The start time in seconds
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public double? StartTime { get; internal set; }
        
        /// <summary>
        /// The duration in seconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; internal set; }
        
        /// <summary>
        /// The number of frames of that video track
        /// </summary>
        [JsonProperty(PropertyName = "numberOfFrames")]
        public long? NumberOfFrames { get; internal set; }
        
        /// <summary>
        /// The aspect ratio of the stream
        /// </summary>
        [JsonProperty(PropertyName = "aspectRatio")]
        public string AspectRatio { get; internal set; }
    }

}
