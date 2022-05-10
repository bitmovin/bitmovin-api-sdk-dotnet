using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamSelectionMode
    /// </summary>
    public enum StreamSelectionMode
    {
        /// <summary>
        /// Automatically select the first stream that fits the Stream&#39;s codec configuration
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// Use the stream specified by &#39;position&#39;
        /// </summary>
        [EnumMember(Value = "POSITION_ABSOLUTE")]
        POSITION_ABSOLUTE,

        /// <summary>
        /// Use the stream specified by &#39;position&#39;, counting video streams only
        /// </summary>
        [EnumMember(Value = "VIDEO_RELATIVE")]
        VIDEO_RELATIVE,

        /// <summary>
        /// Use the stream specified by &#39;position&#39;, counting audio streams only
        /// </summary>
        [EnumMember(Value = "AUDIO_RELATIVE")]
        AUDIO_RELATIVE,

        /// <summary>
        /// Use the stream specified by &#39;position&#39;, counting subtitle streams only
        /// </summary>
        [EnumMember(Value = "SUBTITLE_RELATIVE")]
        SUBTITLE_RELATIVE
    }
}
