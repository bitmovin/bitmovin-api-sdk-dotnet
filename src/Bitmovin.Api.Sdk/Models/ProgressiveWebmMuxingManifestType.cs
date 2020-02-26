using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies the manifest type which will be allowed for the ProgressiveWebmMuxingManifestType Muxing.
    /// </summary>
    public enum ProgressiveWebmMuxingManifestType
    {
        /// <summary>
        /// Allow creation of DASH on-demand manifests
        /// </summary>
        [EnumMember(Value = "DASH_ON_DEMAND")]
        DASH_ON_DEMAND,

        /// <summary>
        /// Do not allow creation of manifests
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE
    }
}
