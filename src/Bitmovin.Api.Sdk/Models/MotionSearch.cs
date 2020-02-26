using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Set the Motion search method
    /// </summary>
    public enum MotionSearch
    {
        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "DIA")]
        DIA,

        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "HEX")]
        HEX,

        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "UMH")]
        UMH,

        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "STAR")]
        STAR,

        /// <summary>
        /// Set the Motion search method
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL
    }
}
