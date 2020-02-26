using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamSelectionMode
    /// </summary>
    public enum StreamSelectionMode
    {
        /// <summary>
        /// Automatically select a stream that fits the codec
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// Use the stream specified by the position attribute
        /// </summary>
        [EnumMember(Value = "POSITION_ABSOLUTE")]
        POSITION_ABSOLUTE,

        /// <summary>
        /// Use the stream specified by position but count only video streams
        /// </summary>
        [EnumMember(Value = "VIDEO_RELATIVE")]
        VIDEO_RELATIVE,

        /// <summary>
        /// Use the stream specified by position but count only audio streams
        /// </summary>
        [EnumMember(Value = "AUDIO_RELATIVE")]
        AUDIO_RELATIVE,

        /// <summary>
        /// Use the stream specified by position but count only subtitle streams
        /// </summary>
        [EnumMember(Value = "SUBTITLE_RELATIVE")]
        SUBTITLE_RELATIVE
    }
}
