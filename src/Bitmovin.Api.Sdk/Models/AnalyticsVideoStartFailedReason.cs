using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsVideoStartFailedReason
    /// </summary>
    public enum AnalyticsVideoStartFailedReason
    {
        /// <summary>
        /// PAGE_CLOSED
        /// </summary>
        [EnumMember(Value = "PAGE_CLOSED")]
        PAGE_CLOSED,

        /// <summary>
        /// PLAYER_ERROR
        /// </summary>
        [EnumMember(Value = "PLAYER_ERROR")]
        PLAYER_ERROR,

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
