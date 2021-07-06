using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Whether to use the Dolby Dialogue Intelligence feature, which identifies and analyzes dialogue segments within audio as a basis for speech gating
    /// </summary>
    public enum DolbyDigitalDialogueIntelligence
    {
        /// <summary>
        /// Enable Dolby Dialogue Intelligence feature
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable Dolby Dialogue Intelligence feature
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
