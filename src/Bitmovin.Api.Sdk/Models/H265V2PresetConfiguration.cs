using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// H265V2PresetConfiguration
    /// </summary>
    public enum H265V2PresetConfiguration
    {
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
