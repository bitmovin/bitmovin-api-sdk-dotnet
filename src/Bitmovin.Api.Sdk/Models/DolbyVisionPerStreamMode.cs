using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyVisionPerStreamMode
    /// </summary>
    public enum DolbyVisionPerStreamMode
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
