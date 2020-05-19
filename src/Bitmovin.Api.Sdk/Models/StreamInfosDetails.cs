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
    /// StreamInfosDetails
    /// </summary>
    public class StreamInfosDetails
    {
        /// <summary>
        /// The id of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The media type of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "mediaType")]
        public MediaType? MediaType { get; set; }

        /// <summary>
        /// The width of the stream, if it is a video stream
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the stream, if it is a video stream
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// The rate (sample rate / fps) of the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public long? Rate { get; set; }

        /// <summary>
        /// The codec of the input stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public LiveEncodingCodec? Codec { get; set; }

        /// <summary>
        /// The minimum samples read per second within the last minute (required)
        /// </summary>
        [JsonProperty(PropertyName = "samplesReadPerSecondMin")]
        public double? SamplesReadPerSecondMin { get; set; }

        /// <summary>
        /// The maximum samples read per second within the last minute (required)
        /// </summary>
        [JsonProperty(PropertyName = "samplesReadPerSecondMax")]
        public double? SamplesReadPerSecondMax { get; set; }

        /// <summary>
        /// The average samples read per second within the last minute (required)
        /// </summary>
        [JsonProperty(PropertyName = "samplesReadPerSecondAvg")]
        public double? SamplesReadPerSecondAvg { get; set; }

        /// <summary>
        /// The minimum amount of backup samples used per second within the last minute. This will be written when no live stream is ingested. The last picture will be repeated with silent audio. (required)
        /// </summary>
        [JsonProperty(PropertyName = "samplesBackupPerSecondMin")]
        public double? SamplesBackupPerSecondMin { get; set; }

        /// <summary>
        /// The maximum amount of backup samples used per second within the last minute. This will be written when no live stream is ingested. The last picture will be repeated with silent audio. (required)
        /// </summary>
        [JsonProperty(PropertyName = "samplesBackupPerSecondMax")]
        public double? SamplesBackupPerSecondMax { get; set; }

        /// <summary>
        /// The average amount of backup samples used per second within the last minute. This will be written when no live stream is ingested. The last picture will be repeated with silent audio. (required)
        /// </summary>
        [JsonProperty(PropertyName = "samplesBackupPerSecondAvg")]
        public double? SamplesBackupPerSecondAvg { get; set; }

        /// <summary>
        /// The minimum bytes read per second within the last minute (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesReadPerSecondMin")]
        public double? BytesReadPerSecondMin { get; set; }

        /// <summary>
        /// The maximum bytes read per second within the last minute (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesReadPerSecondMax")]
        public double? BytesReadPerSecondMax { get; set; }

        /// <summary>
        /// The average bytes read per second within the last minute (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesReadPerSecondAvg")]
        public double? BytesReadPerSecondAvg { get; set; }

        /// <summary>
        /// The minimum amount of backup bytes used per second within the last minute. This will be written when no live stream is ingested. The last picture will be repeated with silent audio. (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesBackupPerSecondMin")]
        public double? BytesBackupPerSecondMin { get; set; }

        /// <summary>
        /// The maximum amount of backup bytes used per second within the last minute. This will be written when no live stream is ingested. The last picture will be repeated with silent audio. (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesBackupPerSecondMax")]
        public double? BytesBackupPerSecondMax { get; set; }

        /// <summary>
        /// The average amount of backup bytes used per second within the last minute. This will be written when no live stream is ingested. The last picture will be repeated with silent audio. (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesBackupPerSecondAvg")]
        public double? BytesBackupPerSecondAvg { get; set; }
    }
}
