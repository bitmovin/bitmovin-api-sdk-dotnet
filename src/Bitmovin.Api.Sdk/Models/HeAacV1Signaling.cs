using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// HeAacV1Signaling
    /// </summary>
    public enum HeAacV1Signaling
    {
        /// <summary>
        /// Implicit backwards compatible signaling.
        /// </summary>
        [EnumMember(Value = "IMPLICIT")]
        IMPLICIT,

        /// <summary>
        /// Explicit SBR signaling. This is backwards compatible.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_SBR")]
        EXPLICIT_SBR,

        /// <summary>
        /// Explicit hierarchical signaling. This is not backwards compatible.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_HIERARCHICAL")]
        EXPLICIT_HIERARCHICAL
    }
}
