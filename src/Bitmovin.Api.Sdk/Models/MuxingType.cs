using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MuxingType
    /// </summary>
    public enum MuxingType
    {
        /// <summary>
        /// FMP4
        /// </summary>
        [EnumMember(Value = "FMP4")]
        FMP4,

        /// <summary>
        /// CMAF
        /// </summary>
        [EnumMember(Value = "CMAF")]
        CMAF,

        /// <summary>
        /// MP4
        /// </summary>
        [EnumMember(Value = "MP4")]
        MP4,

        /// <summary>
        /// TS
        /// </summary>
        [EnumMember(Value = "TS")]
        TS,

        /// <summary>
        /// WEBM
        /// </summary>
        [EnumMember(Value = "WEBM")]
        WEBM,

        /// <summary>
        /// MP3
        /// </summary>
        [EnumMember(Value = "MP3")]
        MP3,

        /// <summary>
        /// MXF
        /// </summary>
        [EnumMember(Value = "MXF")]
        MXF,

        /// <summary>
        /// Single file output as Waveform Audio File Format containing a single PCM audio stream
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_WAV")]
        PROGRESSIVE_WAV,

        /// <summary>
        /// PROGRESSIVE_WEBM
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_WEBM")]
        PROGRESSIVE_WEBM,

        /// <summary>
        /// PROGRESSIVE_MOV
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_MOV")]
        PROGRESSIVE_MOV,

        /// <summary>
        /// PROGRESSIVE_TS
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_TS")]
        PROGRESSIVE_TS,

        /// <summary>
        /// BROADCAST_TS
        /// </summary>
        [EnumMember(Value = "BROADCAST_TS")]
        BROADCAST_TS,

        /// <summary>
        /// CHUNKED_TEXT
        /// </summary>
        [EnumMember(Value = "CHUNKED_TEXT")]
        CHUNKED_TEXT,

        /// <summary>
        /// TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT,

        /// <summary>
        /// SEGMENTED_RAW
        /// </summary>
        [EnumMember(Value = "SEGMENTED_RAW")]
        SEGMENTED_RAW,

        /// <summary>
        /// PACKED_AUDIO
        /// </summary>
        [EnumMember(Value = "PACKED_AUDIO")]
        PACKED_AUDIO
    }
}
