using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ConvertSccPositionMode
    /// </summary>
    public enum ConvertSccPositionMode
    {
        /// <summary>
        /// Use all position information in the output format.
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL,

        /// <summary>
        /// Convert to simple top/bottom center-aligned captions.
        /// </summary>
        [EnumMember(Value = "SIMPLE")]
        SIMPLE,

        /// <summary>
        /// This will remove all position information from the output
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE
    }
}
