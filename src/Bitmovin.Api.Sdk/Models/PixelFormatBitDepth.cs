using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PixelFormatBitDepth
    /// </summary>
    public enum PixelFormatBitDepth
    {
        /// <summary>
        /// Indicates that a pixel format with a bit depth of 8 bit was used
        /// </summary>
        [EnumMember(Value = "EIGHT_BIT")]
        EIGHT_BIT,

        /// <summary>
        /// Indicates that a pixel format with a bit depth of 10 bit was used
        /// </summary>
        [EnumMember(Value = "TEN_BIT")]
        TEN_BIT
    }
}
