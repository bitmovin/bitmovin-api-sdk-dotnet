using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ManifestGenerator
    /// </summary>
    public enum ManifestGenerator
    {
        /// <summary>
        /// Legacy manifest generator.
        /// </summary>
        [EnumMember(Value = "LEGACY")]
        LEGACY,

        /// <summary>
        /// The new manifest generator provides the same functionality as the old one, but it is still under active development and new features will become gradually available.
        /// </summary>
        [EnumMember(Value = "V2_BETA")]
        V2_BETA
    }
}
