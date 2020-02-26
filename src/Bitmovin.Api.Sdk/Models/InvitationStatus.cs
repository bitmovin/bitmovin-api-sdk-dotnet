using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Status of the invitation
    /// </summary>
    public enum InvitationStatus
    {
        /// <summary>
        /// Pending status of the invitation
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,

        /// <summary>
        /// Accepted status of the invitation
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED
    }
}
