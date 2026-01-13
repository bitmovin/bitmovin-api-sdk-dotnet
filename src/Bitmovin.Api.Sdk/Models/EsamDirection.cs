using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ESAM direction indicator following the SCTE-250 standard
    /// </summary>
    public enum EsamDirection
    {
        /// <summary>
        /// Condition as an out-point only (splice out)
        /// </summary>
        [EnumMember(Value = "OUT")]
        OUT,

        /// <summary>
        /// Condition as an in-point only (splice in)
        /// </summary>
        [EnumMember(Value = "IN")]
        IN,

        /// <summary>
        /// Condition for either in or out
        /// </summary>
        [EnumMember(Value = "BOTH")]
        BOTH
    }
}
