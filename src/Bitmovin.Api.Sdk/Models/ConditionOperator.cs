using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The operator that should be used for the evaluation
    /// </summary>
    public enum ConditionOperator
    {
        /// <summary>
        /// Equal
        /// </summary>
        [EnumMember(Value = "==")]
        EQUAL,

        /// <summary>
        /// Not equal
        /// </summary>
        [EnumMember(Value = "!=")]
        NOT_EQUAL,

        /// <summary>
        /// Less than or equal
        /// </summary>
        [EnumMember(Value = "<=")]
        LESS_THAN_OR_EQUAL,

        /// <summary>
        /// Less then
        /// </summary>
        [EnumMember(Value = "<")]
        LESS_THAN,

        /// <summary>
        /// Greater than
        /// </summary>
        [EnumMember(Value = ">")]
        GREATER_THAN,

        /// <summary>
        /// Greater than or equal
        /// </summary>
        [EnumMember(Value = ">=")]
        GREATER_THAN_OR_EQUAL
    }
}
