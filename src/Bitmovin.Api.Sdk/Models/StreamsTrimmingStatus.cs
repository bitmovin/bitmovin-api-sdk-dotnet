using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamsTrimmingStatus
    /// </summary>
    public enum StreamsTrimmingStatus
    {
        /// <summary>
        /// Trimming is unavailable
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE,

        /// <summary>
        /// Trimming is available
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE,

        /// <summary>
        /// The trimming started
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// The trimming failed
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// The trimming succeeded
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED
    }
}
