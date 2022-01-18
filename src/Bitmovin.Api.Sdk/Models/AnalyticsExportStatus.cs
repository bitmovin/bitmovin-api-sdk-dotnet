using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsExportStatus
    /// </summary>
    public enum AnalyticsExportStatus
    {
        /// <summary>
        /// Export has started
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// Export has finished
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,

        /// <summary>
        /// Export is queued and will be stared soon
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,

        /// <summary>
        /// Error has happened during export
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
