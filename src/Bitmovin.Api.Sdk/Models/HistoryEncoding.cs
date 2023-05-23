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
    /// HistoryEncoding
    /// </summary>
    public class HistoryEncoding
    {
        /// <summary>
        /// Encoding
        /// </summary>
        [JsonProperty(PropertyName = "encoding")]
        public Encoding Encoding { get; set; }

        /// <summary>
        /// Live Details
        /// </summary>
        [JsonProperty(PropertyName = "live")]
        public LiveEncoding Live { get; set; }

        /// <summary>
        /// VOD Encoding Start Request
        /// </summary>
        [JsonProperty(PropertyName = "vodStartReqeust")]
        public StartEncodingRequest VodStartReqeust { get; set; }

        /// <summary>
        /// Live Encoding Start Request
        /// </summary>
        [JsonProperty(PropertyName = "liveStartReqeust")]
        public StartLiveEncodingRequest LiveStartReqeust { get; set; }

        /// <summary>
        /// Encoding Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ServiceTaskStatus Status { get; set; }

        /// <summary>
        /// InputStreams
        /// </summary>
        [JsonProperty(PropertyName = "inputStreams")]
        public List<StreamInput> InputStreams { get; set; } = new List<StreamInput>();

        /// <summary>
        /// Streams
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public List<HistoryStream> Streams { get; set; } = new List<HistoryStream>();

        /// <summary>
        /// Muxings
        /// </summary>
        [JsonProperty(PropertyName = "muxings")]
        public List<HistoryMuxing> Muxings { get; set; } = new List<HistoryMuxing>();

        /// <summary>
        /// KeyFrames
        /// </summary>
        [JsonProperty(PropertyName = "keyFrames")]
        public List<Keyframe> KeyFrames { get; set; } = new List<Keyframe>();

        /// <summary>
        /// SidecarFiles
        /// </summary>
        [JsonProperty(PropertyName = "sidecarFiles")]
        public List<SidecarFile> SidecarFiles { get; set; } = new List<SidecarFile>();

        /// <summary>
        /// TransferRetries
        /// </summary>
        [JsonProperty(PropertyName = "transferRetries")]
        public List<TransferRetry> TransferRetries { get; set; } = new List<TransferRetry>();

        /// <summary>
        /// ConvertSccCaptions
        /// </summary>
        [JsonProperty(PropertyName = "convertSccCaptions")]
        public List<ConvertSccCaption> ConvertSccCaptions { get; set; } = new List<ConvertSccCaption>();
    }
}
