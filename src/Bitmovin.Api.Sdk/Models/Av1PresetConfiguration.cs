using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Av1PresetConfiguration
    /// </summary>
    public enum Av1PresetConfiguration
    {
        /// <summary>
        /// VOD_QUALITY
        /// </summary>
        [EnumMember(Value = "VOD_QUALITY")]
        VOD_QUALITY,

        /// <summary>
        /// VOD_STANDARD
        /// </summary>
        [EnumMember(Value = "VOD_STANDARD")]
        VOD_STANDARD,

        /// <summary>
        /// VOD_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_SPEED")]
        VOD_SPEED
    }
}
