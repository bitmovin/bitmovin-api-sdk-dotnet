using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// H265V2PresetConfiguration
    /// </summary>
    public enum H265V2PresetConfiguration
    {
        /// <summary>
        /// VOD_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_SPEED")]
        VOD_SPEED,

        /// <summary>
        /// VOD_STANDARD
        /// </summary>
        [EnumMember(Value = "VOD_STANDARD")]
        VOD_STANDARD,

        /// <summary>
        /// VOD_QUALITY
        /// </summary>
        [EnumMember(Value = "VOD_QUALITY")]
        VOD_QUALITY,

        /// <summary>
        /// VOD_HIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_QUALITY")]
        VOD_HIGH_QUALITY
    }
}
