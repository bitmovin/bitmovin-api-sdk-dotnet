using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// HlsTargetDurationRoundingMode
    /// </summary>
    public enum HlsTargetDurationRoundingMode
    {
        /// <summary>
        /// The target duration will be always rounded upwards.  For example: if the target duration is 4.2 this will be rounded to 5.
        /// </summary>
        [EnumMember(Value = "UPWARD_ROUNDING")]
        UPWARD_ROUNDING,

        /// <summary>
        /// The target duration will be normally rounded.   For example: if the target duration is 4.2 this will be rounded to 4.
        /// </summary>
        [EnumMember(Value = "NORMAL_ROUNDING")]
        NORMAL_ROUNDING
    }
}
