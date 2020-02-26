using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashProfile
    /// </summary>
    public enum DashProfile
    {
        /// <summary>
        /// LIVE can only use fMP4 muxing
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE,

        /// <summary>
        /// ON_DEMAND can only use MP4 muxing
        /// </summary>
        [EnumMember(Value = "ON_DEMAND")]
        ON_DEMAND
    }
}
