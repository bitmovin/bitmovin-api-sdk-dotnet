using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Enable/disable automatic calculation of level, maxBitrate, and bufsize based on the least level that satisfies maximum property values for picture resolution, frame rate, and bit rate.
    /// </summary>
    public enum AutoLevelSetup
    {
        /// <summary>
        /// Enable automatic calculation of level, maxrate and bufsize
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable automatic calculation of level, maxrate and bufsize
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
