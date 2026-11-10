using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MoQ Transport (MoQT) draft version used on the wire. Set on the output and used for the session with the relay.
    /// </summary>
    public enum MoqDraftVersion
    {
        /// <summary>
        /// draft-ietf-moq-transport-16
        /// </summary>
        [EnumMember(Value = "DRAFT_16")]
        DRAFT_16,

        /// <summary>
        /// draft-ietf-moq-transport-18
        /// </summary>
        [EnumMember(Value = "DRAFT_18")]
        DRAFT_18
    }
}
