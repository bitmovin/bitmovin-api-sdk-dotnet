using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// HeAacV2Signaling
    /// </summary>
    public enum HeAacV2Signaling
    {
        /// <summary>
        /// Implicit backwards compatible signaling.
        /// </summary>
        [EnumMember(Value = "IMPLICIT")]
        IMPLICIT,

        /// <summary>
        /// Explicit SBR signaling. Implicit PS signaling. This is backwards compatible.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_SBR")]
        EXPLICIT_SBR,

        /// <summary>
        /// Explicit SBR and PS signaling. This is backwards compatible.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_PS")]
        EXPLICIT_PS,

        /// <summary>
        /// Explicit hierarchical signaling. This is not backwards compatible.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_HIERARCHICAL")]
        EXPLICIT_HIERARCHICAL
    }
}
