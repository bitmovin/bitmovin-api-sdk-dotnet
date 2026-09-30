using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Configures what kind of dynamic range the output should conform to. Can be used to convert between different HDR formats.
    /// </summary>
    public enum Av1DynamicRangeFormat
    {
        /// <summary>
        /// Configure the Output to be Dolby Vision Profile 10.0
        /// </summary>
        [EnumMember(Value = "DOLBY_VISION_PROFILE_10_0")]
        DOLBY_VISION_PROFILE_10_0,

        /// <summary>
        /// Configure the Output to be Dolby Vision Profile 10.1 (HDR10 cross-compatibility)
        /// </summary>
        [EnumMember(Value = "DOLBY_VISION_PROFILE_10_1")]
        DOLBY_VISION_PROFILE_10_1,

        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert between different HDR formats.
        /// </summary>
        [EnumMember(Value = "HDR10")]
        HDR10,

        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert between different HDR formats.
        /// </summary>
        [EnumMember(Value = "SDR")]
        SDR
    }
}
