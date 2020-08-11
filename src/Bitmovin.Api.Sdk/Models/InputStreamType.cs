using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// InputStreamType
    /// </summary>
    public enum InputStreamType
    {
        /// <summary>
        /// INGEST
        /// </summary>
        [EnumMember(Value = "INGEST")]
        INGEST,

        /// <summary>
        /// CONCATENATION
        /// </summary>
        [EnumMember(Value = "CONCATENATION")]
        CONCATENATION,

        /// <summary>
        /// TRIMMING_TIME_BASED
        /// </summary>
        [EnumMember(Value = "TRIMMING_TIME_BASED")]
        TRIMMING_TIME_BASED,

        /// <summary>
        /// TRIMMING_TIME_CODE_TRACK
        /// </summary>
        [EnumMember(Value = "TRIMMING_TIME_CODE_TRACK")]
        TRIMMING_TIME_CODE_TRACK,

        /// <summary>
        /// TRIMMING_H264_PICTURE_TIMING
        /// </summary>
        [EnumMember(Value = "TRIMMING_H264_PICTURE_TIMING")]
        TRIMMING_H264_PICTURE_TIMING,

        /// <summary>
        /// SIDECAR_DOLBY_VISION_METADATA
        /// </summary>
        [EnumMember(Value = "SIDECAR_DOLBY_VISION_METADATA")]
        SIDECAR_DOLBY_VISION_METADATA,

        /// <summary>
        /// AUDIO_MIX
        /// </summary>
        [EnumMember(Value = "AUDIO_MIX")]
        AUDIO_MIX,

        /// <summary>
        /// FILE
        /// </summary>
        [EnumMember(Value = "FILE")]
        FILE,

        /// <summary>
        /// CAPTION_CEA608
        /// </summary>
        [EnumMember(Value = "CAPTION_CEA608")]
        CAPTION_CEA608,

        /// <summary>
        /// CAPTION_CEA708
        /// </summary>
        [EnumMember(Value = "CAPTION_CEA708")]
        CAPTION_CEA708,

        /// <summary>
        /// DVB_SUBTITLE
        /// </summary>
        [EnumMember(Value = "DVB_SUBTITLE")]
        DVB_SUBTITLE,

        /// <summary>
        /// DVB_TELETEXT
        /// </summary>
        [EnumMember(Value = "DVB_TELETEXT")]
        DVB_TELETEXT,

        /// <summary>
        /// DOLBY_ATMOS
        /// </summary>
        [EnumMember(Value = "DOLBY_ATMOS")]
        DOLBY_ATMOS
    }
}
