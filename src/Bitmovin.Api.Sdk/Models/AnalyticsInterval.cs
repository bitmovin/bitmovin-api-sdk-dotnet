using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsInterval
    /// </summary>
    public enum AnalyticsInterval
    {
        /// <summary>
        /// MINUTE
        /// </summary>
        [EnumMember(Value = "MINUTE")]
        MINUTE,

        /// <summary>
        /// HOUR
        /// </summary>
        [EnumMember(Value = "HOUR")]
        HOUR,

        /// <summary>
        /// DAY
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY,

        /// <summary>
        /// MONTH
        /// </summary>
        [EnumMember(Value = "MONTH")]
        MONTH
    }
}
