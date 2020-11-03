using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsRuleMetric
    /// </summary>
    public enum AnalyticsRuleMetric
    {
        /// <summary>
        /// AVG_VIDEO_STARTUPTIME
        /// </summary>
        [EnumMember(Value = "AVG_VIDEO_STARTUPTIME")]
        AVG_VIDEO_STARTUPTIME,

        /// <summary>
        /// MEDIAN_VIDEO_STARTUPTIME
        /// </summary>
        [EnumMember(Value = "MEDIAN_VIDEO_STARTUPTIME")]
        MEDIAN_VIDEO_STARTUPTIME
    }
}
