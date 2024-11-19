using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Type of the manifest
    /// </summary>
    public enum LiveStandbyPoolEncodingManifestType
    {
        /// <summary>
        /// The manifest is a DASH manifest
        /// </summary>
        [EnumMember(Value = "DASH")]
        DASH,

        /// <summary>
        /// The manifest is a HLS manifest
        /// </summary>
        [EnumMember(Value = "HLS")]
        HLS
    }
}
