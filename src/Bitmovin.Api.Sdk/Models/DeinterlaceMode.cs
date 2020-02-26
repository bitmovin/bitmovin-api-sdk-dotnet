using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies the method how fields are converted to frames
    /// </summary>
    public enum DeinterlaceMode
    {
        /// <summary>
        /// Generate one frame for each frame
        /// </summary>
        [EnumMember(Value = "FRAME")]
        FRAME,

        /// <summary>
        /// Generate one frame for each field
        /// </summary>
        [EnumMember(Value = "FIELD")]
        FIELD,

        /// <summary>
        /// Like FRAME, but skip the spatial interlacing check
        /// </summary>
        [EnumMember(Value = "FRAME_NOSPATIAL")]
        FRAME_NOSPATIAL,

        /// <summary>
        /// Like FIELD, but skip the spatial interlacing check
        /// </summary>
        [EnumMember(Value = "FIELD_NOSPATIAL")]
        FIELD_NOSPATIAL
    }
}
