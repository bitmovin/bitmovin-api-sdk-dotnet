using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// NexGuardWatermarkingType
    /// </summary>
    public enum NexGuardWatermarkingType
    {
        /// <summary>
        /// A/B watermarking (for video streams only)
        /// </summary>
        [EnumMember(Value = "OTT")]
        OTT,

        /// <summary>
        /// Stream duplication to match A/B video streams in CDN delivery (for audio streams only)
        /// </summary>
        [EnumMember(Value = "DUPLICATED")]
        DUPLICATED
    }
}
