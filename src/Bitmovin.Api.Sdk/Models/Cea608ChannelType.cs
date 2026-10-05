using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// CEA-608 caption channel, as defined in ANSI/CTA-608-E. Only the primary channel of each field is selectable.
    /// </summary>
    public enum Cea608ChannelType
    {
        /// <summary>
        /// Primary caption channel of field 1, the channel that carries the main captions in almost every stream
        /// </summary>
        [EnumMember(Value = "CC1")]
        CC1,

        /// <summary>
        /// Primary caption channel of field 2, typically used for a secondary language
        /// </summary>
        [EnumMember(Value = "CC3")]
        CC3
    }
}
