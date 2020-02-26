using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsExportStatus
    /// </summary>
    public enum AnalyticsExportStatus
    {
        /// <summary>
        /// STARTED
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,

        /// <summary>
        /// QUEUED
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
