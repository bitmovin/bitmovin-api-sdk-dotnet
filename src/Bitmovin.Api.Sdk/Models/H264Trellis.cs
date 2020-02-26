using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Enables or disables Trellis quantization. NOTE: This requires cabac
    /// </summary>
    public enum H264Trellis
    {
        /// <summary>
        /// Disabled
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,

        /// <summary>
        /// Enabled only on the final encode of a macro block
        /// </summary>
        [EnumMember(Value = "ENABLED_FINAL_MB")]
        ENABLED_FINAL_MB,

        /// <summary>
        /// Enabled on all mode decisions
        /// </summary>
        [EnumMember(Value = "ENABLED_ALL")]
        ENABLED_ALL
    }
}
