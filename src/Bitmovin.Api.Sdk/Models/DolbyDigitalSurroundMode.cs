using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyDigitalSurroundMode
    /// </summary>
    public enum DolbyDigitalSurroundMode
    {
        /// <summary>
        /// Enable Dolby surround mode
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable Dolby surround mode. This is the default value for surroundExMode
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,

        /// <summary>
        /// Dolby surround mode is not indicated. This is the default value for surroundMode
        /// </summary>
        [EnumMember(Value = "NOT_INDICATED")]
        NOT_INDICATED
    }
}
