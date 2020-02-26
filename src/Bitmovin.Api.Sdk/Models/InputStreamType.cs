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
        /// TRIMMINGTIMEBASED
        /// </summary>
        [EnumMember(Value = "TRIMMING_TIME_BASED")]
        TRIMMINGTIMEBASED,

        /// <summary>
        /// TRIMMINGTIMECODETRACK
        /// </summary>
        [EnumMember(Value = "TRIMMING_TIME_CODE_TRACK")]
        TRIMMINGTIMECODETRACK,

        /// <summary>
        /// TRIMMINGH264PICTURETIMING
        /// </summary>
        [EnumMember(Value = "TRIMMING_H264_PICTURE_TIMING")]
        TRIMMINGH264PICTURETIMING,

        /// <summary>
        /// SIDECARDOLBYVISIONMETADATA
        /// </summary>
        [EnumMember(Value = "SIDECAR_DOLBY_VISION_METADATA")]
        SIDECARDOLBYVISIONMETADATA,

        /// <summary>
        /// AUDIOMIX
        /// </summary>
        [EnumMember(Value = "AUDIO_MIX")]
        AUDIOMIX,

        /// <summary>
        /// FILE
        /// </summary>
        [EnumMember(Value = "FILE")]
        FILE,

        /// <summary>
        /// CAPTIONCEA608
        /// </summary>
        [EnumMember(Value = "CAPTION_CEA608")]
        CAPTIONCEA608,

        /// <summary>
        /// CAPTIONCEA708
        /// </summary>
        [EnumMember(Value = "CAPTION_CEA708")]
        CAPTIONCEA708,

        /// <summary>
        /// DVBTELETEXT
        /// </summary>
        [EnumMember(Value = "DVB_TELETEXT")]
        DVBTELETEXT
    }
}
