using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Status of the live standby pool
    /// </summary>
    public enum LiveStandbyPoolStatus
    {
        /// <summary>
        /// The standby pool is in healthy state
        /// </summary>
        [EnumMember(Value = "HEALTHY")]
        HEALTHY,

        /// <summary>
        /// The standby pool is in error state
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
