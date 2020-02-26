using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ManifestType
    /// </summary>
    public enum ManifestType
    {
        /// <summary>
        /// MPEG-DASH manifest
        /// </summary>
        [EnumMember(Value = "DASH")]
        DASH,

        /// <summary>
        /// Apple HTTP Live Streaming manifest
        /// </summary>
        [EnumMember(Value = "HLS")]
        HLS,

        /// <summary>
        /// Microsoft Smooth Streaming manifest
        /// </summary>
        [EnumMember(Value = "SMOOTH_STREAMING")]
        SMOOTH_STREAMING
    }
}
