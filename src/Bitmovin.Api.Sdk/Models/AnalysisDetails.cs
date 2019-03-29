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
    /// AnalysisDetails
    /// </summary>

    public class AnalysisDetails
    {
        /// <summary>
        /// VideoStreams
        /// </summary>
        [JsonProperty(PropertyName = "videoStreams")]
        public List<VideoStreamDetails> VideoStreams { get; set; }
        
        /// <summary>
        /// AudioStreams
        /// </summary>
        [JsonProperty(PropertyName = "audioStreams")]
        public List<AudioStreamDetails> AudioStreams { get; set; }
        
        /// <summary>
        /// MetaStreams
        /// </summary>
        [JsonProperty(PropertyName = "metaStreams")]
        public List<MetaStreamDetails> MetaStreams { get; set; }
        
        /// <summary>
        /// SubtitleStreams
        /// </summary>
        [JsonProperty(PropertyName = "subtitleStreams")]
        public List<SubtitleStreamDetails> SubtitleStreams { get; set; }
    }

}
