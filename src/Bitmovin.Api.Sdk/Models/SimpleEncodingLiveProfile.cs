using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingLiveProfile
    /// </summary>
    public enum SimpleEncodingLiveProfile
    {
        /// <summary>
        /// It provides a higher quality output with a tradeoff in latency
        /// </summary>
        [EnumMember(Value = "INCREASED_QUALITY")]
        INCREASED_QUALITY,

        /// <summary>
        /// It provides a lower latency output with a tradeoff in quality
        /// </summary>
        [EnumMember(Value = "LOWER_LATENCY")]
        LOWER_LATENCY
    }
}
