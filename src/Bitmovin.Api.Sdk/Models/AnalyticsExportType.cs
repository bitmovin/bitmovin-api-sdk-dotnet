using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsExportType
    /// </summary>
    public enum AnalyticsExportType
    {
        /// <summary>
        /// ADS
        /// </summary>
        [EnumMember(Value = "ADS")]
        ADS,

        /// <summary>
        /// SESSIONS
        /// </summary>
        [EnumMember(Value = "SESSIONS")]
        SESSIONS
    }
}
