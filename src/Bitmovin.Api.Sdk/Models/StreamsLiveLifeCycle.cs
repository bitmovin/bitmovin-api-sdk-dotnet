using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamsLiveLifeCycle
    /// </summary>
    public enum StreamsLiveLifeCycle
    {
        /// <summary>
        /// PROVISIONING
        /// </summary>
        [EnumMember(Value = "PROVISIONING")]
        PROVISIONING,

        /// <summary>
        /// STOPPED
        /// </summary>
        [EnumMember(Value = "STOPPED")]
        STOPPED,

        /// <summary>
        /// RUNNING
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
