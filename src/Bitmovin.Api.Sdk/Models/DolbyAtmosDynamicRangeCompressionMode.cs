using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Dynamic range compression processing mode
    /// </summary>
    public enum DolbyAtmosDynamicRangeCompressionMode
    {
        /// <summary>
        /// Film light dynamic range preset except DRC modes are provided as part of Dolby Atmos metadata inside ADM inputs
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// No dynamic range processing preset
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Film standard dynamic range processing preset
        /// </summary>
        [EnumMember(Value = "FILM_STANDARD")]
        FILM_STANDARD,

        /// <summary>
        /// Film light dynamic range processing preset
        /// </summary>
        [EnumMember(Value = "FILM_LIGHT")]
        FILM_LIGHT,

        /// <summary>
        /// Music standard dynamic range processing preset
        /// </summary>
        [EnumMember(Value = "MUSIC_STANDARD")]
        MUSIC_STANDARD,

        /// <summary>
        /// Music light dynamic range processing preset
        /// </summary>
        [EnumMember(Value = "MUSIC_LIGHT")]
        MUSIC_LIGHT,

        /// <summary>
        /// Speech dynamic range processing preset
        /// </summary>
        [EnumMember(Value = "SPEECH")]
        SPEECH
    }
}
