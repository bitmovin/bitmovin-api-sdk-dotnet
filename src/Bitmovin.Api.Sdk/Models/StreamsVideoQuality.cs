using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamsVideoQuality
    /// </summary>
    public enum StreamsVideoQuality
    {
        /// <summary>
        /// The loading placeholder displayed until the first encoding is done
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// A lower quality preview encoding
        /// </summary>
        [EnumMember(Value = "PREVIEW")]
        PREVIEW,

        /// <summary>
        /// The default Per-title encoding
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        /// <summary>
        /// The trimmed Video
        /// </summary>
        [EnumMember(Value = "TRIMMED")]
        TRIMMED
    }
}
