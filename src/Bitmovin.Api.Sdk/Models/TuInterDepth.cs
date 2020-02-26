using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Extra recursion depth for intra coded units
    /// </summary>
    public enum TuInterDepth
    {
        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "1")]
        D1,

        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "2")]
        D2,

        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "3")]
        D3,

        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "4")]
        D4
    }
}
