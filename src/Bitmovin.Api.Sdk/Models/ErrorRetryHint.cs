using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ErrorRetryHint
    /// </summary>
    public enum ErrorRetryHint
    {
        /// <summary>
        /// RETRY
        /// </summary>
        [EnumMember(Value = "RETRY")]
        RETRY,

        /// <summary>
        /// NO_RETRY
        /// </summary>
        [EnumMember(Value = "NO_RETRY")]
        NO_RETRY,

        /// <summary>
        /// RETRY_IN_DIFFERENT_REGION
        /// </summary>
        [EnumMember(Value = "RETRY_IN_DIFFERENT_REGION")]
        RETRY_IN_DIFFERENT_REGION
    }
}
