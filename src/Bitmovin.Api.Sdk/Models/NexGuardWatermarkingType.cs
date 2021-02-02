using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// NexGuardWatermarkingType
    /// </summary>
    public enum NexGuardWatermarkingType
    {
        /// <summary>
        /// A/B watermarking
        /// </summary>
        [EnumMember(Value = "OTT")]
        OTT,

        /// <summary>
        /// Required for Audio to duplicate the stream
        /// </summary>
        [EnumMember(Value = "DUPLICATED")]
        DUPLICATED
    }
}
