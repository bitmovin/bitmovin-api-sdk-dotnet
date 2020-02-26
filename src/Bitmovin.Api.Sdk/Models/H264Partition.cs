using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Partitions to consider. Analyzing more partition options improves quality at the cost of speed.
    /// </summary>
    public enum H264Partition
    {
        /// <summary>
        /// Consider no macroblocks
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Consider P-macroblocks with size 8x8, 16X8, 8X16
        /// </summary>
        [EnumMember(Value = "P8X8")]
        P8X8,

        /// <summary>
        /// Consider P-macroblocks with size 4x4, 8X4, 4x8
        /// </summary>
        [EnumMember(Value = "P4X4")]
        P4X4,

        /// <summary>
        /// Consider B-macroblocks with size 8x8, 16X8, 8X16
        /// </summary>
        [EnumMember(Value = "B8X8")]
        B8X8,

        /// <summary>
        /// Consider I-macroblocks with size 8x8
        /// </summary>
        [EnumMember(Value = "I8X8")]
        I8X8,

        /// <summary>
        /// Consider I-macroblocks with size 4x4
        /// </summary>
        [EnumMember(Value = "I4X4")]
        I4X4,

        /// <summary>
        /// Consider all possible sizes of macroblocks
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL
    }
}
