using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashRepresentationTypeMode
    /// </summary>
    public enum DashRepresentationTypeMode
    {
        /// <summary>
        /// Generates representations containing segment templates.
        /// </summary>
        [EnumMember(Value = "TEMPLATE_REPRESENTATION")]
        TEMPLATE_REPRESENTATION,

        /// <summary>
        /// Generates segment templates in the adaption sets. The representations will not contain any segment templates anymore.
        /// </summary>
        [EnumMember(Value = "TEMPLATE_ADAPTATION_SET")]
        TEMPLATE_ADAPTATION_SET
    }
}
