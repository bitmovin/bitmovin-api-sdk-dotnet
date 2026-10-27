using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Controls encoder tuning that preserves film grain and fine detail at a negligible bitrate increase
    /// </summary>
    public enum Av1DetailPreservationMode
    {
        /// <summary>
        /// Detail preservation is applied to the renditions where it is most effective: those whose resolution is at least 25% (in pixels) of the highest AV1 rendition of the encoding
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// Detail preservation is applied to all renditions
        /// </summary>
        [EnumMember(Value = "ON")]
        ON,

        /// <summary>
        /// Detail preservation is disabled
        /// </summary>
        [EnumMember(Value = "OFF")]
        OFF
    }
}
