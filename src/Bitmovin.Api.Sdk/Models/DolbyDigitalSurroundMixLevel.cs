using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyDigitalSurroundMixLevel
    /// </summary>
    public enum DolbyDigitalSurroundMixLevel
    {
        /// <summary>
        /// -1.5 dB
        /// </summary>
        [EnumMember(Value = "MINUS_1_5_DB")]
        MINUS_1_5_DB,

        /// <summary>
        /// -3 dB
        /// </summary>
        [EnumMember(Value = "MINUS_3_DB")]
        MINUS_3_DB,

        /// <summary>
        /// -4.5 dB
        /// </summary>
        [EnumMember(Value = "MINUS_4_5_DB")]
        MINUS_4_5_DB,

        /// <summary>
        /// -6 dB
        /// </summary>
        [EnumMember(Value = "MINUS_6_DB")]
        MINUS_6_DB,

        /// <summary>
        /// MINUS_INFINITY_DB
        /// </summary>
        [EnumMember(Value = "MINUS_INFINITY_DB")]
        MINUS_INFINITY_DB
    }
}
