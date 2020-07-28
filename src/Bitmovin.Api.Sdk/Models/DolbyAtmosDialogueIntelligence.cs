using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Whether to use the Dialogue Intelligence feature, which identifies and analyzes dialogue segments within audio as a basis for speech gating
    /// </summary>
    public enum DolbyAtmosDialogueIntelligence
    {
        /// <summary>
        /// Enable Dialogue Intelligence feature
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable Dialogue Intelligence feature
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
