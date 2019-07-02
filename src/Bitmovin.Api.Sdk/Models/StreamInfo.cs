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
    /// StreamInfo
    /// </summary>

    public class StreamInfo : BitmovinResource
    {
        /// <summary>
        /// It MUST match the value of the GROUP-ID attribute of an Audio EXT-X-MEDIA tag elsewhere in the Master Playlist. Either this or &#x60;audioGroups&#x60; must be set.
        /// </summary>
        [JsonProperty(PropertyName = "audio")]
        public string Audio { get; set; }
        
        /// <summary>
        /// HLS Audio Group Configuration. You will want to use this configuration property in case you specify conditions on audio streams. The first matching audio group will be used for the specific variant stream. Either this or &#x60;audio&#x60; must be set.
        /// </summary>
        [JsonProperty(PropertyName = "audioGroups")]
        public AudioGroupConfiguration AudioGroups { get; set; }
        
        /// <summary>
        /// It MUST match the value of the GROUP-ID attribute of a Video EXT-X-MEDIA tag elsewhere in the Master Playlist
        /// </summary>
        [JsonProperty(PropertyName = "video")]
        public string Video { get; set; }
        
        /// <summary>
        /// It MUST match the value of the GROUP-ID attribute of a Subtitles EXT-X-MEDIA tag elsewhere in the Master Playlist
        /// </summary>
        [JsonProperty(PropertyName = "subtitles")]
        public string Subtitles { get; set; }
        
        /// <summary>
        /// If the value is not &#39;NONE&#39;, it MUST match the value of the GROUP-ID attribute of a Closed Captions EXT-X-MEDIA tag elsewhere in the Playlist (required)
        /// </summary>
        [JsonProperty(PropertyName = "closedCaptions")]
        public string ClosedCaptions { get; set; }
        
        /// <summary>
        /// Id of the encoding. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }
        
        /// <summary>
        /// Id of the stream. (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        /// <summary>
        /// Id of the muxing. (required)
        /// </summary>
        [JsonProperty(PropertyName = "muxingId")]
        public string MuxingId { get; set; }
        
        /// <summary>
        /// Id of the DRM.
        /// </summary>
        [JsonProperty(PropertyName = "drmId")]
        public string DrmId { get; set; }
        
        /// <summary>
        /// Path to segments. (required)
        /// </summary>
        [JsonProperty(PropertyName = "segmentPath")]
        public string SegmentPath { get; set; }
        
        /// <summary>
        /// The URI of the playlist file. (required)
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <summary>
        /// Number of the first segment. Default is 0.
        /// </summary>
        [JsonProperty(PropertyName = "startSegmentNumber")]
        public long? StartSegmentNumber { get; set; }
        
        /// <summary>
        /// Number of the last segment. Default is the last one that was encoded.
        /// </summary>
        [JsonProperty(PropertyName = "endSegmentNumber")]
        public long? EndSegmentNumber { get; set; }
        
        /// <summary>
        /// Force the addition of the frame rate attribute to all stream infos.
        /// </summary>
        [JsonProperty(PropertyName = "forceFrameRateAttribute")]
        public bool? ForceFrameRateAttribute { get; set; }
        
        /// <summary>
        /// Force the addition of the video-range attribute to all stream infos.
        /// </summary>
        [JsonProperty(PropertyName = "forceVideoRangeAttribute")]
        public bool? ForceVideoRangeAttribute { get; set; }
    }

}
