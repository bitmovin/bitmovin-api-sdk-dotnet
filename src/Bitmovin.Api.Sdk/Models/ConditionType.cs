using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Type of the condition
    /// </summary>
    public enum ConditionType
    {
        /// <summary>
        /// Type of the condition
        /// </summary>
        [EnumMember(Value = "CONDITION")]
        CONDITION,

        /// <summary>
        /// Type of the condition
        /// </summary>
        [EnumMember(Value = "AND")]
        AND,

        /// <summary>
        /// Type of the condition
        /// </summary>
        [EnumMember(Value = "OR")]
        OR
    }
}
