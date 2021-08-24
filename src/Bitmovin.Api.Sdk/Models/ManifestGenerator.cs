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
        /// Improved manifest generator which covers all manifest features available in our API.
        /// </summary>
        [EnumMember(Value = "V2")]
        V2
    }
}
