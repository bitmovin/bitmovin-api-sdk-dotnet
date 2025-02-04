using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashISO8601TimestampFormat
    /// </summary>
    public enum DashISO8601TimestampFormat
    {
        /// <summary>
        /// Format for generating timestamps in PXXYXXMXXDTXXHXXMX.XXXS
        /// </summary>
        [EnumMember(Value = "LONG")]
        LONG,

        /// <summary>
        /// Format for generating timestamps in PTXXHXXMX.XXXS
        /// </summary>
        [EnumMember(Value = "SHORT")]
        SHORT
    }
}
