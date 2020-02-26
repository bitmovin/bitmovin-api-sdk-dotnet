using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ChannelLayout
    /// </summary>
    public enum ChannelLayout
    {
        /// <summary>
        /// No channel layout
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Channel layout Mono
        /// </summary>
        [EnumMember(Value = "MONO")]
        MONO,

        /// <summary>
        /// Channel layout Stereo
        /// </summary>
        [EnumMember(Value = "STEREO")]
        CL_STEREO
    }
}
