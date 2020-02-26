using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PositionUnit
    /// </summary>
    public enum PositionUnit
    {
        /// <summary>
        /// PIXELS
        /// </summary>
        [EnumMember(Value = "PIXELS")]
        PIXELS,

        /// <summary>
        /// PERCENTS
        /// </summary>
        [EnumMember(Value = "PERCENTS")]
        PERCENTS
    }
}
