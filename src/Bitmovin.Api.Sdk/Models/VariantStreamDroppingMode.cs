using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Variant stream dropping mode.
    /// </summary>
    public enum VariantStreamDroppingMode
    {
        /// <summary>
        /// Variant stream dropping mode.
        /// </summary>
        [EnumMember(Value = "STREAM")]
        STREAM,

        /// <summary>
        /// Variant stream dropping mode.
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO
    }
}
