using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Determines quality for the price of speed.
    /// </summary>
    public enum Vp8Quality
    {
        /// <summary>
        /// Determines quality for the price of speed.
        /// </summary>
        [EnumMember(Value = "REALTIME")]
        REALTIME,

        /// <summary>
        /// Determines quality for the price of speed.
        /// </summary>
        [EnumMember(Value = "GOOD")]
        GOOD,

        /// <summary>
        /// Determines quality for the price of speed.
        /// </summary>
        [EnumMember(Value = "BEST")]
        BEST
    }
}
