using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ProfileH264
    /// </summary>
    public enum ProfileH264
    {
        /// <summary>
        /// Baseline profile
        /// </summary>
        [EnumMember(Value = "BASELINE")]
        BASELINE,

        /// <summary>
        /// Main profile
        /// </summary>
        [EnumMember(Value = "MAIN")]
        MAIN,

        /// <summary>
        /// High profile
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH
    }
}
