using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Status of the standby pool encoding
    /// </summary>
    public enum LiveStandbyPoolEncodingStatus
    {
        /// <summary>
        /// The encoding is about to be created
        /// </summary>
        [EnumMember(Value = "TO_BE_CREATED")]
        TO_BE_CREATED,

        /// <summary>
        /// The encoding is being created
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING,

        /// <summary>
        /// The encoding is starting and configured and not ready for streaming yet
        /// </summary>
        [EnumMember(Value = "PREPARING")]
        PREPARING,

        /// <summary>
        /// The encoding is ready to be acquired from the pool
        /// </summary>
        [EnumMember(Value = "READY")]
        READY,

        /// <summary>
        /// The encoding is about to be deleted
        /// </summary>
        [EnumMember(Value = "TO_BE_DELETED")]
        TO_BE_DELETED,

        /// <summary>
        /// The encoding is being deleted
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING,

        /// <summary>
        /// The encoding of the pool is acquired and removed from the pool
        /// </summary>
        [EnumMember(Value = "ACQUIRED")]
        ACQUIRED,

        /// <summary>
        /// The encoding of the pool is in error state
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
