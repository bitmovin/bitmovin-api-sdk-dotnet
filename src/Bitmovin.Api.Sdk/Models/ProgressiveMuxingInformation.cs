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
    /// ProgressiveMuxingInformation
    /// </summary>

    public class ProgressiveMuxingInformation
    {
        /// <summary>
        /// The mime type of the muxing
        /// </summary>
        [JsonProperty(PropertyName = "mimeType")]
        public string MimeType { get; internal set; }
        
        /// <summary>
        /// The file size of the muxing in bytes
        /// </summary>
        [JsonProperty(PropertyName = "fileSize")]
        public long? FileSize { get; internal set; }
        
        /// <summary>
        /// The container format used
        /// </summary>
        [JsonProperty(PropertyName = "containerFormat")]
        public string ContainerFormat { get; internal set; }
        
        /// <summary>
        /// The bitrate of the container if available (tracks + container overhead)
        /// </summary>
        [JsonProperty(PropertyName = "containerBitrate")]
        public long? ContainerBitrate { get; internal set; }
        
        /// <summary>
        /// The duration of the container in seconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; internal set; }
        
        /// <summary>
        /// Information about the video tracks in the container
        /// </summary>
        [JsonProperty(PropertyName = "videoTracks")]
        public List<MuxingInformationVideoTrack> VideoTracks { get; internal set; }
        
        /// <summary>
        /// Information about the audio tracks in the container
        /// </summary>
        [JsonProperty(PropertyName = "audioTracks")]
        public List<MuxingInformationAudioTrack> AudioTracks { get; internal set; }
    }

}
