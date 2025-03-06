using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AiServiceProvider
    /// </summary>
    public enum AiServiceProvider
    {
        /// <summary>
        /// Gemini by Google AI
        /// </summary>
        [EnumMember(Value = "GOOGLE")]
        GOOGLE
    }
}
