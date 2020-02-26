using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// LogLevel
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// TRACE
        /// </summary>
        [EnumMember(Value = "TRACE")]
        TRACE,

        /// <summary>
        /// DEBUG
        /// </summary>
        [EnumMember(Value = "DEBUG")]
        DEBUG,

        /// <summary>
        /// INFO
        /// </summary>
        [EnumMember(Value = "INFO")]
        INFO,

        /// <summary>
        /// WARN
        /// </summary>
        [EnumMember(Value = "WARN")]
        WARN,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// FATAL
        /// </summary>
        [EnumMember(Value = "FATAL")]
        FATAL,

        /// <summary>
        /// OFF
        /// </summary>
        [EnumMember(Value = "OFF")]
        OFF
    }
}
