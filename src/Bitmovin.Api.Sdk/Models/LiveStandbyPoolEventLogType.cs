using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Event log type of the standby pool
    /// </summary>
    public enum LiveStandbyPoolEventLogType
    {
        /// <summary>
        /// Info log level
        /// </summary>
        [EnumMember(Value = "INFO")]
        INFO,

        /// <summary>
        /// Warning log level
        /// </summary>
        [EnumMember(Value = "WARN")]
        WARN,

        /// <summary>
        /// Error log level
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
