using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StatisticsPerTitleStream
    /// </summary>
    public enum StatisticsPerTitleStream
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
