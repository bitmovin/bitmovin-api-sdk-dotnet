using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsExportType
    /// </summary>
    public enum AnalyticsExportType
    {
        /// <summary>
        /// Export ads sessions
        /// </summary>
        [EnumMember(Value = "ADS")]
        ADS,

        /// <summary>
        /// Export sessions
        /// </summary>
        [EnumMember(Value = "SESSIONS")]
        SESSIONS
    }
}
