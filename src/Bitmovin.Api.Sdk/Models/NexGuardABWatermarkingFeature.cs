using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// NexGuardABWatermarkingFeature
    /// </summary>
    public enum NexGuardABWatermarkingFeature
    {
        /// <summary>
        /// For video streams with NexGuard FileMarker OTT Watermarking
        /// </summary>
        [EnumMember(Value = "OTT")]
        OTT,

        /// <summary>
        /// For audio streams that have been duplicated for NexGuard A/B Watermarking
        /// </summary>
        [EnumMember(Value = "DUPLICATED")]
        DUPLICATED
    }
}
