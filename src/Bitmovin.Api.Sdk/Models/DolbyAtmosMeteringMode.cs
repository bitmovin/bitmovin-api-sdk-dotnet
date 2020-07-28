using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Algorithm to be used for measuring loudness
    /// </summary>
    public enum DolbyAtmosMeteringMode
    {
        /// <summary>
        /// ITU-R BS.1770-1
        /// </summary>
        [EnumMember(Value = "ITU-R BS.1770-1")]
        ITU_R_BS_1770_1,

        /// <summary>
        /// ITU-R BS.1770-2
        /// </summary>
        [EnumMember(Value = "ITU-R BS.1770-2")]
        ITU_R_BS_1770_2,

        /// <summary>
        /// ITU-R BS.1770-3
        /// </summary>
        [EnumMember(Value = "ITU-R BS.1770-3")]
        ITU_R_BS_1770_3,

        /// <summary>
        /// ITU-R BS.1770-4
        /// </summary>
        [EnumMember(Value = "ITU-R BS.1770-4")]
        ITU_R_BS_1770_4,

        /// <summary>
        /// Leq (A)
        /// </summary>
        [EnumMember(Value = "Leq (A)")]
        LEQ_A
    }
}
