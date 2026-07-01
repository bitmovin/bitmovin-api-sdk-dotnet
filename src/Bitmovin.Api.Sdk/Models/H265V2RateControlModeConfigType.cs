using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// H265V2RateControlModeConfigType
    /// </summary>
    public enum H265V2RateControlModeConfigType
    {
        /// <summary>
        /// PERCEPTUAL_QUALITY_MODE
        /// </summary>
        [EnumMember(Value = "PERCEPTUAL_QUALITY_MODE")]
        PERCEPTUAL_QUALITY_MODE,

        /// <summary>
        /// CONSTANT_BITRATE_MODE
        /// </summary>
        [EnumMember(Value = "CONSTANT_BITRATE_MODE")]
        CONSTANT_BITRATE_MODE
    }
}
