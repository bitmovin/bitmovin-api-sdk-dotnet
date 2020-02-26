using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsOrder
    /// </summary>
    public enum AnalyticsOrder
    {
        /// <summary>
        /// ASC
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,

        /// <summary>
        /// DESC
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC
    }
}
