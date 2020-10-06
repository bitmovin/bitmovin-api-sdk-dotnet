using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// EgressCategory
    /// </summary>
    public enum EgressCategory
    {
        /// <summary>
        /// TRANSFER_RETRY
        /// </summary>
        [EnumMember(Value = "TRANSFER_RETRY")]
        TRANSFER_RETRY,

        /// <summary>
        /// TRANSFER
        /// </summary>
        [EnumMember(Value = "TRANSFER")]
        TRANSFER
    }
}
