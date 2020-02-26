using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Enable evaluation of transform skip (bypass DCT but still use quantization) coding for 4x4 TU coded blocks.
    /// </summary>
    public enum TransformSkipMode
    {
        /// <summary>
        /// No transform skip enabled
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Enable normal evaluation of transform skip
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        NORMAL,

        /// <summary>
        /// Only evaluate transform skip for NxN intra predictions (4x4 blocks).
        /// </summary>
        [EnumMember(Value = "FAST")]
        FAST
    }
}
