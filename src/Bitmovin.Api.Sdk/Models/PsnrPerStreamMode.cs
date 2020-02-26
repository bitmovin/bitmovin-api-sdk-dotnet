using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PsnrPerStreamMode
    /// </summary>
    public enum PsnrPerStreamMode
    {
        /// <summary>
        /// DISABLED
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,

        /// <summary>
        /// ENABLED
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED
    }
}
