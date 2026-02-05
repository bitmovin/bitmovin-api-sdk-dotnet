using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ScenePacing
    /// </summary>
    public enum ScenePacing
    {
        /// <summary>
        /// Deliberate, unhurried pace with contemplative moments or establishing shots
        /// </summary>
        [EnumMember(Value = "SLOW")]
        SLOW,

        /// <summary>
        /// Steady, controlled pace typical of dialogue-driven scenes or methodical storytelling
        /// </summary>
        [EnumMember(Value = "MEASURED")]
        MEASURED,

        /// <summary>
        /// Quick, energetic pace found in action sequences or montages
        /// </summary>
        [EnumMember(Value = "BRISK")]
        BRISK,

        /// <summary>
        /// Rapid, chaotic pace with intense action or panic-driven scenes
        /// </summary>
        [EnumMember(Value = "FRANTIC")]
        FRANTIC,

        /// <summary>
        /// Unable to determine pacing
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
