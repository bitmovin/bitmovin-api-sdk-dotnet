using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SceneTension
    /// </summary>
    public enum SceneTension
    {
        /// <summary>
        /// Peak suspense or intensity, such as climactic confrontations or life-threatening situations
        /// </summary>
        [EnumMember(Value = "EXTREME")]
        EXTREME,

        /// <summary>
        /// Significant tension with emotionally charged moments, such as arguments or chase scenes
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH,

        /// <summary>
        /// Some tension present, engaging but not overwhelming, such as mild conflict or anticipation
        /// </summary>
        [EnumMember(Value = "MODERATE")]
        MODERATE,

        /// <summary>
        /// Minimal tension with calm or relaxed scenes, such as exposition or casual dialogue
        /// </summary>
        [EnumMember(Value = "LOW")]
        LOW,

        /// <summary>
        /// Unable to determine tension level
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
