using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// OrganizationType
    /// </summary>
    public enum OrganizationType
    {
        /// <summary>
        /// ROOTORGANIZATION
        /// </summary>
        [EnumMember(Value = "ROOT_ORGANIZATION")]
        ROOTORGANIZATION,

        /// <summary>
        /// SUBORGANIZATION
        /// </summary>
        [EnumMember(Value = "SUB_ORGANIZATION")]
        SUBORGANIZATION
    }
}
