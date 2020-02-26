using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AclPermission
    /// </summary>
    public enum AclPermission
    {
        /// <summary>
        /// PUBLICREAD
        /// </summary>
        [EnumMember(Value = "PUBLIC_READ")]
        PUBLICREAD,

        /// <summary>
        /// PRIVATE
        /// </summary>
        [EnumMember(Value = "PRIVATE")]
        PRIVATE
    }
}
