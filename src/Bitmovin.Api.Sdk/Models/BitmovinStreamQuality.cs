using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// BitmovinStreamQuality
    /// </summary>
    public enum BitmovinStreamQuality
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
        DEFAULT
    }
}
