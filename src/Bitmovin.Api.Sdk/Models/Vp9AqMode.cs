using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Adaptive quantization mode.
    /// </summary>
    public enum Vp9AqMode
    {
        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "VARIANCE")]
        VARIANCE,

        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "COMPLEXITY")]
        COMPLEXITY,

        /// <summary>
        /// Adaptive quantization mode.
        /// </summary>
        [EnumMember(Value = "CYCLIC")]
        CYCLIC
    }
}
