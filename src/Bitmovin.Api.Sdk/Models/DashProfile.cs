using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashProfile
    /// </summary>
    public enum DashProfile
    {
        /// <summary>
        /// Profile that supports segmented representations/muxings (FMP4, CMAF, WEBM, CHUNKED_TEXT)
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE,

        /// <summary>
        /// Profile that supports progressive representations/muxings (MP4, PROGRESSIVE_WEBM)
        /// </summary>
        [EnumMember(Value = "ON_DEMAND")]
        ON_DEMAND
    }
}
