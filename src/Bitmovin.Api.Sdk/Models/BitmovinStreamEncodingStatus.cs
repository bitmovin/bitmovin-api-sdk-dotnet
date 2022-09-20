using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// BitmovinStreamEncodingStatus
    /// </summary>
    public enum BitmovinStreamEncodingStatus
    {
        /// <summary>
        /// The encoding has been started and is in progress
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// The encoding did not succeed
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// The encoding finished successfully
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED
    }
}
