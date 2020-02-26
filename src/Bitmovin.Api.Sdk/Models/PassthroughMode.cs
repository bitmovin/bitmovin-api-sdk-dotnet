using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Configure if the encoding should use the video stream as the passthrough mode or a dedicated caption stream.
    /// </summary>
    public enum PassthroughMode
    {
        /// <summary>
        /// Configure if the encoding should use the video stream as the passthrough mode or a dedicated caption stream.
        /// </summary>
        [EnumMember(Value = "VIDEO_STREAM")]
        VIDEO_STREAM,

        /// <summary>
        /// Configure if the encoding should use the video stream as the passthrough mode or a dedicated caption stream.
        /// </summary>
        [EnumMember(Value = "CAPTION_STREAM")]
        CAPTION_STREAM
    }
}
