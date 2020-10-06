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
        /// TO_BE_DESCHEDULED
        /// </summary>
        [EnumMember(Value = "TO_BE_DESCHEDULED")]
        TO_BE_DESCHEDULED,

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
