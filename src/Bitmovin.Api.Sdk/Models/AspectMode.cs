using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AspectMode
    /// </summary>
    public enum AspectMode
    {
        /// <summary>
        /// Specifies that the Padding aspect mode is used when adapting to the main input stream&#39;s aspect ratio (Adding black boxes on the bottom/top or left/right).
        /// </summary>
        [EnumMember(Value = "PAD")]
        PAD,

        /// <summary>
        /// Specifies that the Cropping aspect mode is used when adapting to the main input stream&#39;s aspect ratio (Cropping on the left/right or bottom/top).
        /// </summary>
        [EnumMember(Value = "CROP")]
        CROP,

        /// <summary>
        /// Specifies that the Stretching aspect mode is used when adapting to the main input stream&#39;s aspect ratio (Stretching vertically or horizontally).
        /// </summary>
        [EnumMember(Value = "STRETCH")]
        STRETCH
    }
}
