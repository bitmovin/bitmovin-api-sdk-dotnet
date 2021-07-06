using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Enable Dolby Evolution Framework control feature
    /// </summary>
    public enum DolbyDigitalPlusEvolutionFrameworkControl
    {
        /// <summary>
        /// Enable Dolby Evolution Framework control feature
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable Dolby Evolution Framework control feature
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
