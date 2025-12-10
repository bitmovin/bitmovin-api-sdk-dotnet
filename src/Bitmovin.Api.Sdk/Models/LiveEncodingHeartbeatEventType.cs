using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// LiveEncodingHeartbeatEventType
    /// </summary>
    public enum LiveEncodingHeartbeatEventType
    {
        /// <summary>
        /// First connection of the ingest
        /// </summary>
        [EnumMember(Value = "FIRST_CONNECT")]
        FIRST_CONNECT,

        /// <summary>
        /// Ingest has disconnected
        /// </summary>
        [EnumMember(Value = "DISCONNECT")]
        DISCONNECT,

        /// <summary>
        /// Ingest has reconnected
        /// </summary>
        [EnumMember(Value = "RECONNECT")]
        RECONNECT,

        /// <summary>
        /// Warning occurred, please see the message for further details
        /// </summary>
        [EnumMember(Value = "WARNING")]
        WARNING,

        /// <summary>
        /// Error occurred, please see the message for further details
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
