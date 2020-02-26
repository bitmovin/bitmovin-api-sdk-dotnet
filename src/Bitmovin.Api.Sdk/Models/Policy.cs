using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The policy for the permissions.
    /// </summary>
    public enum Policy
    {
        /// <summary>
        /// Allows access to given permissions.
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        ALLOW,

        /// <summary>
        /// Denies access to given permissions.
        /// </summary>
        [EnumMember(Value = "DENY")]
        DENY
    }
}
