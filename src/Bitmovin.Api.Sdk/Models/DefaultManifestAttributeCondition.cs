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
    /// DefaultManifestAttributeCondition
    /// </summary>
    public class DefaultManifestAttributeCondition : DefaultManifestCondition
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "CONDITION";
#pragma warning restore CS0414

        /// <summary>
        /// The attribute that should be used for the evaluation: - audio.codec - audio.language - audio.bitrate - subtitle.format - subtitle.language - video.height - video.width - video.codec - video.bitrate - drm.type - muxing.type (required)
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// The operator that should be used for the evaluation (required)
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public ConditionOperator? Operator { get; set; }

        /// <summary>
        /// The value that should be used for comparison. Valid values depend on the attribute: - audio.codec (Enum; e.g., AAC, MP3, OPUS) - audio.language (String) - audio.bitrate (Integer) - subtitle.format (Enum; e.g., WEBVTT) - subtitle.language (String) - video.height (Integer) - video.width (Integer) - video.codec (Enum; e.g., AV1, H264, VP9) - video.bitrate (Integer) - drm.type (Enum; NoDrm, Cenc, CencWidevine, CencPlayReady, CencMarlin, CencFairPlay, Aes128, ClearKey, PrimeTime, Widevine, PlayReady, Marlin, FairPlay) - muxing.type (Enum; e.g., FMP4, MP4) (required)
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
