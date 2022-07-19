using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashProfile
    /// </summary>
    public enum DashProfile
    {
        /// <summary>
        /// The profile to be used for fMP4 muxings
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE,

        /// <summary>
        /// The profile to be used for MP4 muxings
        /// </summary>
        [EnumMember(Value = "ON_DEMAND")]
        ON_DEMAND
    }
}
