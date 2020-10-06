using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MediaInfoType
    /// </summary>
    public enum MediaInfoType
    {
        /// <summary>
        /// AUDIO
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO,

        /// <summary>
        /// VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,

        /// <summary>
        /// SUBTITLES
        /// </summary>
        [EnumMember(Value = "SUBTITLES")]
        SUBTITLES,

        /// <summary>
        /// CLOSED_CAPTIONS
        /// </summary>
        [EnumMember(Value = "CLOSED_CAPTIONS")]
        CLOSED_CAPTIONS,

        /// <summary>
        /// VTT
        /// </summary>
        [EnumMember(Value = "VTT")]
        VTT
    }
}
