using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ThumbnailAspectMode
    /// </summary>
    public enum ThumbnailAspectMode
    {
        /// <summary>
        /// Specifies that the Padding aspect mode is used when adapting to configured the width and height.  Padding means that either horiziontally or vertically black boxes are added to make sure that the thumbnail image fits the aspect ratio.
        /// </summary>
        [EnumMember(Value = "PAD")]
        PAD,

        /// <summary>
        /// Specifies that the Cropping aspect mode is used when adapting to configured the width and height.  Cropping means that parts of the image are removed so that the thumbnail fits the aspect ratio.
        /// </summary>
        [EnumMember(Value = "CROP")]
        CROP,

        /// <summary>
        /// Specifies that the Stretching aspect mode is used when adapting to configured the width and height.  Stretching means that the image is stretched either vertically or horizontally until it fits the aspect ratio.
        /// </summary>
        [EnumMember(Value = "STRETCH")]
        STRETCH
    }
}
