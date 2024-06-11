using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// FilterType
    /// </summary>
    public enum FilterType
    {
        /// <summary>
        /// CROP
        /// </summary>
        [EnumMember(Value = "CROP")]
        CROP,

        /// <summary>
        /// CONFORM
        /// </summary>
        [EnumMember(Value = "CONFORM")]
        CONFORM,

        /// <summary>
        /// WATERMARK
        /// </summary>
        [EnumMember(Value = "WATERMARK")]
        WATERMARK,

        /// <summary>
        /// ENHANCED_WATERMARK
        /// </summary>
        [EnumMember(Value = "ENHANCED_WATERMARK")]
        ENHANCED_WATERMARK,

        /// <summary>
        /// ROTATE
        /// </summary>
        [EnumMember(Value = "ROTATE")]
        ROTATE,

        /// <summary>
        /// DEINTERLACE
        /// </summary>
        [EnumMember(Value = "DEINTERLACE")]
        DEINTERLACE,

        /// <summary>
        /// ENHANCED_DEINTERLACE
        /// </summary>
        [EnumMember(Value = "ENHANCED_DEINTERLACE")]
        ENHANCED_DEINTERLACE,

        /// <summary>
        /// AUDIO_MIX
        /// </summary>
        [EnumMember(Value = "AUDIO_MIX")]
        AUDIO_MIX,

        /// <summary>
        /// DENOISE_HQDN3D
        /// </summary>
        [EnumMember(Value = "DENOISE_HQDN3D")]
        DENOISE_HQDN3D,

        /// <summary>
        /// TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT,

        /// <summary>
        /// UNSHARP
        /// </summary>
        [EnumMember(Value = "UNSHARP")]
        UNSHARP,

        /// <summary>
        /// SCALE
        /// </summary>
        [EnumMember(Value = "SCALE")]
        SCALE,

        /// <summary>
        /// INTERLACE
        /// </summary>
        [EnumMember(Value = "INTERLACE")]
        INTERLACE,

        /// <summary>
        /// AUDIO_VOLUME
        /// </summary>
        [EnumMember(Value = "AUDIO_VOLUME")]
        AUDIO_VOLUME,

        /// <summary>
        /// EBU_R128_SINGLE_PASS
        /// </summary>
        [EnumMember(Value = "EBU_R128_SINGLE_PASS")]
        EBU_R128_SINGLE_PASS,

        /// <summary>
        /// AZURE_SPEECH_TO_CAPTIONS
        /// </summary>
        [EnumMember(Value = "AZURE_SPEECH_TO_CAPTIONS")]
        AZURE_SPEECH_TO_CAPTIONS
    }
}
