using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The color range to be applied
    /// </summary>
    public enum ColorRange
    {
        /// <summary>
        /// The color range to be applied
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        /// <summary>
        /// The color range to be applied
        /// </summary>
        [EnumMember(Value = "MPEG")]
        MPEG,

        /// <summary>
        /// The color range to be applied
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG
    }
}
