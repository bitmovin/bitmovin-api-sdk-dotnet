using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies which field of an interlaced frame is assumed to be the first one
    /// </summary>
    public enum PictureFieldParity
    {
        /// <summary>
        /// Automatic detection of field parity
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// Top field is first field
        /// </summary>
        [EnumMember(Value = "TOP_FIELD_FIRST")]
        TOP_FIELD_FIRST,

        /// <summary>
        /// Bottom field is first field
        /// </summary>
        [EnumMember(Value = "BOTTOM_FIELD_FIRST")]
        BOTTOM_FIELD_FIRST
    }
}
