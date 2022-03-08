using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingLiveInputAspectRatio
    /// </summary>
    public enum SimpleEncodingLiveInputAspectRatio
    {
        /// <summary>
        /// Widescreen 16:9 aspect ratio
        /// </summary>
        [EnumMember(Value = "WIDE_16_9")]
        WIDE_16_9,

        /// <summary>
        /// Widescreen 16:10 aspect ratio
        /// </summary>
        [EnumMember(Value = "WIDE_16_10")]
        WIDE_16_10,

        /// <summary>
        /// Vertical 9:16 aspect ratio. Also known as portrait mode
        /// </summary>
        [EnumMember(Value = "VERTICAL_9_16")]
        VERTICAL_9_16,

        /// <summary>
        /// Standard 4:3 aspect ratio
        /// </summary>
        [EnumMember(Value = "STANDARD_4_3")]
        STANDARD_4_3,

        /// <summary>
        /// Ultrawide 21:9 aspect ratio
        /// </summary>
        [EnumMember(Value = "ULTRA_WIDE_21_9")]
        ULTRA_WIDE_21_9
    }
}
