using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Configure if the encoding should use the video stream as the passthrough mode or a dedicated caption stream.
    /// </summary>
    public enum PassthroughMode
    {
        /// <summary>
        /// Select the embedded captions from the video stream
        /// </summary>
        [EnumMember(Value = "VIDEO_STREAM")]
        VIDEO_STREAM,

        /// <summary>
        /// Select the captions from a separate caption stream
        /// </summary>
        [EnumMember(Value = "CAPTION_STREAM")]
        CAPTION_STREAM,

        /// <summary>
        /// Select the captions from the video stream or from the caption stream. Don&#39;t use this option if the input file contains both caption variants.
        /// </summary>
        [EnumMember(Value = "VIDEO_CAPTION_STREAM")]
        VIDEO_CAPTION_STREAM
    }
}
