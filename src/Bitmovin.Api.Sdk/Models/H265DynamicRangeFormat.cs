using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HDR, from HDR to SDR or between different HDR formats
    /// </summary>
    public enum H265DynamicRangeFormat
    {
        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HDR, from HDR to SDR or between different HDR formats
        /// </summary>
        [EnumMember(Value = "DOLBY_VISION")]
        DOLBY_VISION,

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
