using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ChannelsAttributeForAudio
    /// </summary>
    public enum ChannelsAttributeForAudio
    {
        /// <summary>
        /// Always add CHANNELS attribute
        /// </summary>
        [EnumMember(Value = "ALWAYS")]
        ALWAYS,

        /// <summary>
        /// Add CHANNELS attribute according to the HLS specifications
        /// </summary>
        [EnumMember(Value = "STANDARD_CONFORM")]
        STANDARD_CONFORM,

        /// <summary>
        /// Legacy setting for the CHANNELS attribute
        /// </summary>
        [EnumMember(Value = "LEGACY")]
        LEGACY
    }
}
