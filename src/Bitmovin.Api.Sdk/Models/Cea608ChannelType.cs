using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Subtitle channel track
    /// </summary>
    public enum Cea608ChannelType
    {
        /// <summary>
        /// Subtitle channel track
        /// </summary>
        [EnumMember(Value = "CC1")]
        CC1,

        /// <summary>
        /// Subtitle channel track
        /// </summary>
        [EnumMember(Value = "CC3")]
        CC3
    }
}
