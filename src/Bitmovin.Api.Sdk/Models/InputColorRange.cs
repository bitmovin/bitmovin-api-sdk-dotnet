using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
    /// </summary>
    public enum InputColorRange
    {
        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "MPEG")]
        MPEG,

        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG
    }
}
