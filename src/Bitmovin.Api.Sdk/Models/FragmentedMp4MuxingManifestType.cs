using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Manifest type to be generated for the Fragmented MP4 Muxing. Only significant if a valid fragmentDuration is passed. If this is not set, Smooth Streaming is assumed.
    /// </summary>
    public enum FragmentedMp4MuxingManifestType
    {
        /// <summary>
        /// Smooth Streaming manifest
        /// </summary>
        [EnumMember(Value = "SMOOTH")]
        SMOOTH,

        /// <summary>
        /// DASH On-demand manifest
        /// </summary>
        [EnumMember(Value = "DASH_ON_DEMAND")]
        DASH_ON_DEMAND,

        /// <summary>
        /// HLS manifest with byte ranges
        /// </summary>
        [EnumMember(Value = "HLS_BYTE_RANGES")]
        HLS_BYTE_RANGES,

        /// <summary>
        /// Do not create a manifest
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// HLS manifest with byte ranges and I-frame playlist
        /// </summary>
        [EnumMember(Value = "HLS_BYTE_RANGES_AND_IFRAME_PLAYLIST")]
        HLS_BYTE_RANGES_AND_IFRAME_PLAYLIST
    }
}
