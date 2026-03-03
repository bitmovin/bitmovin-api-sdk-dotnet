using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AgentChatMessagePartType
    /// </summary>
    public enum AgentChatMessagePartType
    {
        /// <summary>
        /// TEXT
        /// </summary>
        [EnumMember(Value = "text")]
        TEXT,

        /// <summary>
        /// DATA_ATTACHMENTS
        /// </summary>
        [EnumMember(Value = "data-attachments")]
        DATA_ATTACHMENTS
    }
}
