using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DecodingErrorMode
    /// </summary>
    public enum DecodingErrorMode
    {
        /// <summary>
        /// Encoding will fail, if there are errors during decoding of this stream
        /// </summary>
        [EnumMember(Value = "FAIL_ON_ERROR")]
        FAIL_ON_ERROR,

        /// <summary>
        /// If a frame is undecodable, other frames will be duplicated to compensate for the lost frame. The encoding will not fail, but there will be warnings about which frames could not be decoded.
        /// </summary>
        [EnumMember(Value = "DUPLICATE_FRAMES")]
        DUPLICATE_FRAMES
    }
}
