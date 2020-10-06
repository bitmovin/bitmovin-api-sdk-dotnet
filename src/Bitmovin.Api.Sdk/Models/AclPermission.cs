using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AclPermission
    /// </summary>
    public enum AclPermission
    {
        /// <summary>
        /// PUBLIC_READ
        /// </summary>
        [EnumMember(Value = "PUBLIC_READ")]
        PUBLIC_READ,

        /// <summary>
        /// PRIVATE
        /// </summary>
        [EnumMember(Value = "PRIVATE")]
        PRIVATE
    }
}
