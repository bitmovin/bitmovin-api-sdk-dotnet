using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// TextFilterFont
    /// </summary>
    public enum TextFilterFont
    {
        /// <summary>
        /// DEJAVUSANS
        /// </summary>
        [EnumMember(Value = "DEJAVUSANS")]
        DEJAVUSANS,

        /// <summary>
        /// DEJAVUSERIF
        /// </summary>
        [EnumMember(Value = "DEJAVUSERIF")]
        DEJAVUSERIF,

        /// <summary>
        /// DEJAVUSANSMONO
        /// </summary>
        [EnumMember(Value = "DEJAVUSANSMONO")]
        DEJAVUSANSMONO,

        /// <summary>
        /// ROBOTOMONO
        /// </summary>
        [EnumMember(Value = "ROBOTOMONO")]
        ROBOTOMONO,

        /// <summary>
        /// ROBOTOBLACK
        /// </summary>
        [EnumMember(Value = "ROBOTOBLACK")]
        ROBOTOBLACK,

        /// <summary>
        /// ROBOTO
        /// </summary>
        [EnumMember(Value = "ROBOTO")]
        ROBOTO,

        /// <summary>
        /// ROBOTOCONDENSED
        /// </summary>
        [EnumMember(Value = "ROBOTOCONDENSED")]
        ROBOTOCONDENSED
    }
}
