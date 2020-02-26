using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Using TOP_FIELD_FIRST or BOTTOM_FIELD_FIRST will output interlaced video
    /// </summary>
    public enum H264InterlaceMode
    {
        /// <summary>
        /// Using TOP_FIELD_FIRST or BOTTOM_FIELD_FIRST will output interlaced video
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Using TOP_FIELD_FIRST or BOTTOM_FIELD_FIRST will output interlaced video
        /// </summary>
        [EnumMember(Value = "TOP_FIELD_FIRST")]
        TOP_FIELD_FIRST,

        /// <summary>
        /// Using TOP_FIELD_FIRST or BOTTOM_FIELD_FIRST will output interlaced video
        /// </summary>
        [EnumMember(Value = "BOTTOM_FIELD_FIRST")]
        BOTTOM_FIELD_FIRST
    }
}
