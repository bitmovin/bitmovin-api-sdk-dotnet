using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsVideoStartFailedReason
    /// </summary>
    public enum AnalyticsVideoStartFailedReason
    {
        /// <summary>
        /// PAGECLOSED
        /// </summary>
        [EnumMember(Value = "PAGE_CLOSED")]
        PAGECLOSED,

        /// <summary>
        /// PLAYERERROR
        /// </summary>
        [EnumMember(Value = "PLAYER_ERROR")]
        PLAYERERROR,

        /// <summary>
        /// TIMEOUT
        /// </summary>
        [EnumMember(Value = "TIMEOUT")]
        TIMEOUT,

        /// <summary>
        /// UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
