using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SpriteCreationMode
    /// </summary>
    public enum SpriteCreationMode
    {
        /// <summary>
        /// Creation of the thumbnails starts after the first period interval configured.  When using distance&#x3D;10 and unit&#x3D;SECONDS, the first image of the sprite is from second 10 of the video.
        /// </summary>
        [EnumMember(Value = "INTERVAL_END")]
        INTERVAL_END,

        /// <summary>
        /// Creation of the thumbnails starts at the beginning of the first period interval configured, therefore, at the beginning of the video.  When using distance&#x3D;10 and unit&#x3D;SECONDS, the first image of the sprite is from the very start of the video, while the second image is from second 10 of the video.
        /// </summary>
        [EnumMember(Value = "INTERVAL_START")]
        INTERVAL_START
    }
}
