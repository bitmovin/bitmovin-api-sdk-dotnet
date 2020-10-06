using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// LiveEncodingStatus
    /// </summary>
    public enum LiveEncodingStatus
    {
        /// <summary>
        /// CONNECTED
        /// </summary>
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        /// <summary>
        /// DISCONNECTED
        /// </summary>
        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        /// <summary>
        /// WAITING_FOR_FIRST_CONNECT
        /// </summary>
        [EnumMember(Value = "WAITING_FOR_FIRST_CONNECT")]
        WAITING_FOR_FIRST_CONNECT,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// NOT_AVAILABLE
        /// </summary>
        [EnumMember(Value = "NOT_AVAILABLE")]
        NOT_AVAILABLE,

        /// <summary>
        /// FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED
    }
}
