using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AkamaiCloudRegion
    /// </summary>
    public enum AkamaiCloudRegion
    {
        /// <summary>
        /// São Paulo, Brazil
        /// </summary>
        [EnumMember(Value = "BR_GRU")]
        BR_GRU,

        /// <summary>
        /// Madrid, Spain
        /// </summary>
        [EnumMember(Value = "ES_MAD")]
        ES_MAD,

        /// <summary>
        /// Paris, France
        /// </summary>
        [EnumMember(Value = "FR_PAR")]
        FR_PAR,

        /// <summary>
        /// Jakarta, Indonesia
        /// </summary>
        [EnumMember(Value = "ID_CGK")]
        ID_CGK,

        /// <summary>
        /// Chennai, India
        /// </summary>
        [EnumMember(Value = "IN_MAA")]
        IN_MAA,

        /// <summary>
        /// Milan, Italy
        /// </summary>
        [EnumMember(Value = "IT_MIL")]
        IT_MIL,

        /// <summary>
        /// Osaka, Japan
        /// </summary>
        [EnumMember(Value = "JP_OSA")]
        JP_OSA,

        /// <summary>
        /// Amsterdam, Netherlands
        /// </summary>
        [EnumMember(Value = "NL_AMS")]
        NL_AMS,

        /// <summary>
        /// Stockholm, Sweden
        /// </summary>
        [EnumMember(Value = "SE_STO")]
        SE_STO,

        /// <summary>
        /// Los Angeles, USA
        /// </summary>
        [EnumMember(Value = "US_LAX")]
        US_LAX,

        /// <summary>
        /// Miami, USA
        /// </summary>
        [EnumMember(Value = "US_MIA")]
        US_MIA,

        /// <summary>
        /// Chicago, USA
        /// </summary>
        [EnumMember(Value = "US_ORD")]
        US_ORD,

        /// <summary>
        /// Seattle, USA
        /// </summary>
        [EnumMember(Value = "US_SEA")]
        US_SEA
    }
}
