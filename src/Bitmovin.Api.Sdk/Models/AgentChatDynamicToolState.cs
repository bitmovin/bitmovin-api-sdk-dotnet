using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AgentChatDynamicToolState
    /// </summary>
    public enum AgentChatDynamicToolState
    {
        /// <summary>
        /// INPUT_STREAMING
        /// </summary>
        [EnumMember(Value = "input-streaming")]
        INPUT_STREAMING,

        /// <summary>
        /// INPUT_AVAILABLE
        /// </summary>
        [EnumMember(Value = "input-available")]
        INPUT_AVAILABLE,

        /// <summary>
        /// OUTPUT_AVAILABLE
        /// </summary>
        [EnumMember(Value = "output-available")]
        OUTPUT_AVAILABLE,

        /// <summary>
        /// OUTPUT_ERROR
        /// </summary>
        [EnumMember(Value = "output-error")]
        OUTPUT_ERROR
    }
}
