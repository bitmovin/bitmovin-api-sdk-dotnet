using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsQueryOperator
    /// </summary>
    public enum AnalyticsQueryOperator
    {
        /// <summary>
        /// IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN,

        /// <summary>
        /// EQ
        /// </summary>
        [EnumMember(Value = "EQ")]
        EQ,

        /// <summary>
        /// NE
        /// </summary>
        [EnumMember(Value = "NE")]
        NE,

        /// <summary>
        /// LT
        /// </summary>
        [EnumMember(Value = "LT")]
        LT,

        /// <summary>
        /// LTE
        /// </summary>
        [EnumMember(Value = "LTE")]
        LTE,

        /// <summary>
        /// GT
        /// </summary>
        [EnumMember(Value = "GT")]
        GT,

        /// <summary>
        /// GTE
        /// </summary>
        [EnumMember(Value = "GTE")]
        GTE,

        /// <summary>
        /// CONTAINS
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS,

        /// <summary>
        /// NOTCONTAINS
        /// </summary>
        [EnumMember(Value = "NOTCONTAINS")]
        NOTCONTAINS
    }
}
