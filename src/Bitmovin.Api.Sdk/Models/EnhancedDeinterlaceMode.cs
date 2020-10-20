using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies the method how fields are converted to frames
    /// </summary>
    public enum EnhancedDeinterlaceMode
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
        FIELD
    }
}
