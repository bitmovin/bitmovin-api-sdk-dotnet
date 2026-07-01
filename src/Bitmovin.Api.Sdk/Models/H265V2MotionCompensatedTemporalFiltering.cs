using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// H265V2MotionCompensatedTemporalFiltering
    /// </summary>
    public enum H265V2MotionCompensatedTemporalFiltering
    {
        /// <summary>
        /// -1: Automatic selection
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// 0: Disable motion compensated temporal filtering
        /// </summary>
        [EnumMember(Value = "OFF")]
        OFF,

        /// <summary>
        /// 1: Enable motion compensated temporal filtering
        /// </summary>
        [EnumMember(Value = "ON")]
        ON
    }
}
