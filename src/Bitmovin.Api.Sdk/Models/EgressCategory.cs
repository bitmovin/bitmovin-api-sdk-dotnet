using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// EgressCategory
    /// </summary>
    public enum EgressCategory
    {
        /// <summary>
        /// TRANSFERRETRY
        /// </summary>
        [EnumMember(Value = "TRANSFER_RETRY")]
        TRANSFERRETRY,

        /// <summary>
        /// TRANSFER
        /// </summary>
        [EnumMember(Value = "TRANSFER")]
        TRANSFER
    }
}
