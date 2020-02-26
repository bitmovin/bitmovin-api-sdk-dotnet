using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ScheduledInsertableContentStatus
    /// </summary>
    public enum ScheduledInsertableContentStatus
    {
        /// <summary>
        /// CREATED
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// SCHEDULED
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,

        /// <summary>
        /// TOBEDESCHEDULED
        /// </summary>
        [EnumMember(Value = "TO_BE_DESCHEDULED")]
        TOBEDESCHEDULED,

        /// <summary>
        /// DESCHEDULED
        /// </summary>
        [EnumMember(Value = "DESCHEDULED")]
        DESCHEDULED,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
