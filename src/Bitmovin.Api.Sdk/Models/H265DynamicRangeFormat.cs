using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HDR, from HDR to SDR or between different HDR formats
    /// </summary>
    public enum H265DynamicRangeFormat
    {
        /// <summary>
        /// Configure the Output to be Dolby Vision Profile 5.
        /// </summary>
        [EnumMember(Value = "DOLBY_VISION")]
        DOLBY_VISION,

        /// <summary>
        /// Configure the Output to be Dolby Vision Profile 5
        /// </summary>
        [EnumMember(Value = "DOLBY_VISION_PROFILE_5")]
        DOLBY_VISION_PROFILE_5,

        /// <summary>
        /// Configure the Output to be Dolby Vision Profile 8.1 (HDR10 cross-compatibility)
        /// </summary>
        [EnumMember(Value = "DOLBY_VISION_PROFILE_8_1")]
        DOLBY_VISION_PROFILE_8_1,

        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HDR, from HDR to SDR or between different HDR formats
        /// </summary>
        [EnumMember(Value = "HDR10")]
        HDR10,

        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HDR, from HDR to SDR or between different HDR formats
        /// </summary>
        [EnumMember(Value = "HLG")]
        HLG,

        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HDR, from HDR to SDR or between different HDR formats
        /// </summary>
        [EnumMember(Value = "SDR")]
        SDR
    }
}
