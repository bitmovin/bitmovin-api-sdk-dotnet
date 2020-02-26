using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Enable adaptive quantization for sub-CTUs. This parameter specifies the minimum CU size at which QP can be adjusted.
    /// </summary>
    public enum QuantizationGroupSize
    {
        /// <summary>
        /// 8x8
        /// </summary>
        [EnumMember(Value = "QGS_8x8")]
        QGS_8x8,

        /// <summary>
        /// 16x16
        /// </summary>
        [EnumMember(Value = "QGS_16x16")]
        QGS_16x16,

        /// <summary>
        /// 32x32
        /// </summary>
        [EnumMember(Value = "QGS_32x32")]
        QGS_32x32,

        /// <summary>
        /// 64x64
        /// </summary>
        [EnumMember(Value = "QGS_64x64")]
        QGS_64x64
    }
}
