using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AV1 has a segment based feature that allows the encoder to adaptively change quantization parameter for each segment within a frame
    /// </summary>
    public enum Av1AdaptiveQuantMode
    {
        /// <summary>
        /// AV1 has a segment based feature that allows the encoder to adaptively change quantization parameter for each segment within a frame
        /// </summary>
        [EnumMember(Value = "OFF")]
        OFF,

        /// <summary>
        /// AV1 has a segment based feature that allows the encoder to adaptively change quantization parameter for each segment within a frame
        /// </summary>
        [EnumMember(Value = "VARIANCE")]
        VARIANCE,

        /// <summary>
        /// AV1 has a segment based feature that allows the encoder to adaptively change quantization parameter for each segment within a frame
        /// </summary>
        [EnumMember(Value = "COMPLEXITY")]
        COMPLEXITY,

        /// <summary>
        /// AV1 has a segment based feature that allows the encoder to adaptively change quantization parameter for each segment within a frame
        /// </summary>
        [EnumMember(Value = "CYCLIC_REFRESH")]
        CYCLIC_REFRESH,

        /// <summary>
        /// AV1 has a segment based feature that allows the encoder to adaptively change quantization parameter for each segment within a frame
        /// </summary>
        [EnumMember(Value = "DELTA_QUANT")]
        DELTA_QUANT
    }
}
