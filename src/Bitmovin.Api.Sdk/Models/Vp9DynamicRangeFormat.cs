using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HLG, from HLG to SDR.
    /// </summary>
    public enum Vp9DynamicRangeFormat
    {
        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HLG, from HLG to SDR.
        /// </summary>
        [EnumMember(Value = "HLG")]
        HLG,

        /// <summary>
        /// Configures what kind of dynamic range the output should conform to. Can be used to convert from SDR to HLG, from HLG to SDR.
        /// </summary>
        [EnumMember(Value = "SDR")]
        SDR
    }
}
