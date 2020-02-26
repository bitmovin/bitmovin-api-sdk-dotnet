using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MaxTransformUnitSize
    /// </summary>
    public enum MaxTransformUnitSize
    {
        /// <summary>
        /// maximum 4x4 TU
        /// </summary>
        [EnumMember(Value = "MTU_4x4")]
        MTU_4x4,

        /// <summary>
        /// maximum 8x8 TU
        /// </summary>
        [EnumMember(Value = "MTU_8x8")]
        MTU_8x8,

        /// <summary>
        /// maximum 16x16 TU
        /// </summary>
        [EnumMember(Value = "MTU_16x16")]
        MTU_16x16,

        /// <summary>
        /// maximum 32x32 TU
        /// </summary>
        [EnumMember(Value = "MTU_32x32")]
        MTU_32x32
    }
}
