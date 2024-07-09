using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PcmChannelLayout
    /// </summary>
    public enum PcmChannelLayout
    {
        /// <summary>
        /// Channel layout with single channel
        /// </summary>
        [EnumMember(Value = "MONO")]
        MONO,

        /// <summary>
        /// Channel layout with left and right channel
        /// </summary>
        [EnumMember(Value = "STEREO")]
        STEREO
    }
}
