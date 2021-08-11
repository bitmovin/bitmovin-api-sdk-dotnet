using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DtsMode
    /// </summary>
    public enum DtsMode
    {
        /// <summary>
        /// DTS Express Audio
        /// </summary>
        [EnumMember(Value = "EXPRESS_AUDIO")]
        EXPRESS_AUDIO,

        /// <summary>
        /// DTS Digital Surround
        /// </summary>
        [EnumMember(Value = "DIGITAL_SURROUND")]
        DIGITAL_SURROUND
    }
}
