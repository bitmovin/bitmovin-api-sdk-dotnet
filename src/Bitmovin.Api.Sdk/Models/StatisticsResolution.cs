using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StatisticsResolution
    /// </summary>
    public enum StatisticsResolution
    {
        /// <summary>
        /// SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD,

        /// <summary>
        /// HD
        /// </summary>
        [EnumMember(Value = "HD")]
        HD,

        /// <summary>
        /// UHD
        /// </summary>
        [EnumMember(Value = "UHD")]
        UHD,

        /// <summary>
        /// UHD8K
        /// </summary>
        [EnumMember(Value = "UHD_8K")]
        UHD8K
    }
}
