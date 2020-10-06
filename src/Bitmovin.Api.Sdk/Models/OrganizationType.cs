using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// OrganizationType
    /// </summary>
    public enum OrganizationType
    {
        /// <summary>
        /// ROOT_ORGANIZATION
        /// </summary>
        [EnumMember(Value = "ROOT_ORGANIZATION")]
        ROOT_ORGANIZATION,

        /// <summary>
        /// SUB_ORGANIZATION
        /// </summary>
        [EnumMember(Value = "SUB_ORGANIZATION")]
        SUB_ORGANIZATION
    }
}
