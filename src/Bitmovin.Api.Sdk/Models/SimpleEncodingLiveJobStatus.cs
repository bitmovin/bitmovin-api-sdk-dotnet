using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingLiveJobStatus
    /// </summary>
    public enum SimpleEncodingLiveJobStatus
    {
        /// <summary>
        /// The Simple Encoding Live Job has been created and is waiting to be executed
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// The Simple Encoding Live Job is currently being executed and creating the encoding
        /// </summary>
        [EnumMember(Value = "EXECUTING")]
        EXECUTING,

        /// <summary>
        /// The Simple Encoding Live Job could not create the encoding, check the details for more information
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        FAILURE,

        /// <summary>
        /// The Simple Encoding Live Job has triggered the encoding and is currently starting
        /// </summary>
        [EnumMember(Value = "STARTING")]
        STARTING,

        /// <summary>
        /// The Simple Encoding Live Job has triggered the encoding and is accepting/encoding ingress
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,

        /// <summary>
        /// The Simple Encoding Live Job has been executed and the encoding has finished
        /// </summary>
        [EnumMember(Value = "STOPPED")]
        STOPPED,

        /// <summary>
        /// The Simple Encoding Live Job has been executed but the encoding failed, check the encoding details for more information
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// The Simple Encoding Live Job has been executed but the encoding has been canceled manually by the user
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED
    }
}
