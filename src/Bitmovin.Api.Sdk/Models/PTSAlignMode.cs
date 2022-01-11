using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Alignmet mode for PTS
    /// </summary>
    public enum PTSAlignMode
    {
        /// <summary>
        /// Align the initial PTS to zero using negative CTS offsets. This is achieved by using &#x60;trun&#x60; version 1 boxes in the mp4 fragments.
        /// </summary>
        [EnumMember(Value = "ALIGN_ZERO_NEGATIVE_CTO")]
        ALIGN_ZERO_NEGATIVE_CTO
    }
}
