using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Status
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The process has been created, but not started yet
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// The process has been enqueued for execution and will start as soon as resources are available
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,

        /// <summary>
        /// The process is being executed
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,

        /// <summary>
        /// The process was finished successfully. This is a final state
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,

        /// <summary>
        /// The process has stopped due to an error. This is a final state
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// The process has been canceled by the user. This is a final state
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,

        /// <summary>
        /// The process has finished successfully, but at least one transfer to a configured output failed. The transfer attempt can be retried.
        /// </summary>
        [EnumMember(Value = "TRANSFER_ERROR")]
        TRANSFER_ERROR
    }
}
