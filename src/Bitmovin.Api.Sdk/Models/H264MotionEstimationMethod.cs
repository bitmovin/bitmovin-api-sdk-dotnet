using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Integer pixel motion estimation method
    /// </summary>
    public enum H264MotionEstimationMethod
    {
        /// <summary>
        /// diamond search, radius 1 (fast)
        /// </summary>
        [EnumMember(Value = "DIA")]
        DIA,

        /// <summary>
        /// hexagonal search, radius 2
        /// </summary>
        [EnumMember(Value = "HEX")]
        HEX,

        /// <summary>
        /// uneven multi-hexagon search
        /// </summary>
        [EnumMember(Value = "UMH")]
        UMH
    }
}
