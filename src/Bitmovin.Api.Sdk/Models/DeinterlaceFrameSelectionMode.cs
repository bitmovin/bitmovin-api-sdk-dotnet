using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies which frames to deinterlace
    /// </summary>
    public enum DeinterlaceFrameSelectionMode
    {
        /// <summary>
        /// Deinterlace all frames
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL,

        /// <summary>
        /// Only deinterlace frames marked as interlaced. This option is only supported for deinterlace modes &#39;FRAME&#39; and &#39;FRAME_NOSPATIAL&#39;
        /// </summary>
        [EnumMember(Value = "INTERLACED")]
        INTERLACED
    }
}
