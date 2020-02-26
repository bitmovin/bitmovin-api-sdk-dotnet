using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Keep some B-frames as references
    /// </summary>
    public enum H264BPyramid
    {
        /// <summary>
        /// Do not keep b-frame references
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Use a strictly hierarchical pyramid
        /// </summary>
        [EnumMember(Value = "STRICT")]
        STRICT,

        /// <summary>
        /// Non-strict, recommended (increases decoding picture buffer)
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        NORMAL
    }
}
