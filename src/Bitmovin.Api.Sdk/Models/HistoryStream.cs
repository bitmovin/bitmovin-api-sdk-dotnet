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
    /// HistoryStream
    /// </summary>
    public class HistoryStream
    {
        /// <summary>
        /// Stream
        /// </summary>
        [JsonProperty(PropertyName = "stream")]
        public Stream Stream { get; set; }

        /// <summary>
        /// List of stream filter configurations
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<StreamFilter> Filters { get; set; } = new List<StreamFilter>();

        /// <summary>
        /// List of Burn-In DVB-SUB subtitles
        /// </summary>
        [JsonProperty(PropertyName = "burnInSubtitleDvbSubs")]
        public List<BurnInSubtitleDvbSub> BurnInSubtitleDvbSubs { get; set; } = new List<BurnInSubtitleDvbSub>();

        /// <summary>
        /// List of burn-in SRT configurations
        /// </summary>
        [JsonProperty(PropertyName = "burnInSubtitleSrtSubs")]
        public List<BurnInSubtitleSrt> BurnInSubtitleSrtSubs { get; set; } = new List<BurnInSubtitleSrt>();

        /// <summary>
        /// Nexguard file marker watermarking configuration
        /// </summary>
        [JsonProperty(PropertyName = "nexGuardFileMarker")]
        public NexGuardFileMarker NexGuardFileMarker { get; set; }

        /// <summary>
        /// List of caption configurations
        /// </summary>
        [JsonProperty(PropertyName = "sccCaptions")]
        public List<SccCaption> SccCaptions { get; set; } = new List<SccCaption>();

        /// <summary>
        /// List of bif configurations
        /// </summary>
        [JsonProperty(PropertyName = "bifs")]
        public List<Bif> Bifs { get; set; } = new List<Bif>();

        /// <summary>
        /// List of Dolby Vision Metadata configurations
        /// </summary>
        [JsonProperty(PropertyName = "dolbyVisionMetadata")]
        public List<DolbyVisionMetadata> DolbyVisionMetadata { get; set; } = new List<DolbyVisionMetadata>();

        /// <summary>
        /// List of Thumbnail configurations
        /// </summary>
        [JsonProperty(PropertyName = "thumbnails")]
        public List<Thumbnail> Thumbnails { get; set; } = new List<Thumbnail>();

        /// <summary>
        /// List of Sprite configurations
        /// </summary>
        [JsonProperty(PropertyName = "sprites")]
        public List<Sprite> Sprites { get; set; } = new List<Sprite>();

        /// <summary>
        /// List of PSNR quality metrics
        /// </summary>
        [JsonProperty(PropertyName = "psnrMetrics")]
        public List<PsnrQualityMetric> PsnrMetrics { get; set; } = new List<PsnrQualityMetric>();
    }
}
