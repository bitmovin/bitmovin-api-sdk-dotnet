using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MessageType
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// WARNING
        /// </summary>
        [EnumMember(Value = "WARNING")]
        WARNING,

        /// <summary>
        /// INFO
        /// </summary>
        [EnumMember(Value = "INFO")]
        INFO,

        /// <summary>
        /// DEBUG
        /// </summary>
        [EnumMember(Value = "DEBUG")]
        DEBUG,

        /// <summary>
        /// TRACE
        /// </summary>
        [EnumMember(Value = "TRACE")]
        TRACE
    }
}
