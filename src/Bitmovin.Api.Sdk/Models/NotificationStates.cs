using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// NotificationStates
    /// </summary>
    public enum NotificationStates
    {
        /// <summary>
        /// The Notification is fired
        /// </summary>
        [EnumMember(Value = "FIRED")]
        FIRED,

        /// <summary>
        /// The Notification is resolved
        /// </summary>
        [EnumMember(Value = "RESOLVED")]
        RESOLVED
    }
}
