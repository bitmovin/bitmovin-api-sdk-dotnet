using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyDigitalPlusCenterMixLevel
    /// </summary>
    public enum DolbyDigitalPlusCenterMixLevel
    {
        /// <summary>
        /// +3 dB
        /// </summary>
        [EnumMember(Value = "PLUS_3_DB")]
        PLUS_3_DB,

        /// <summary>
        /// +1.5 dB
        /// </summary>
        [EnumMember(Value = "PLUS_1_5_DB")]
        PLUS_1_5_DB,

        /// <summary>
        /// 0 dB
        /// </summary>
        [EnumMember(Value = "ZERO_DB")]
        ZERO_DB,

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
        /// -∞ dB
        /// </summary>
        [EnumMember(Value = "MINUS_INFINITY_DB")]
        MINUS_INFINITY_DB
    }
}
