using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AkamaiMslStreamFormat
    /// </summary>
    public enum AkamaiMslStreamFormat
    {
        /// <summary>
        /// DASH
        /// </summary>
        [EnumMember(Value = "DASH")]
        DASH,

        /// <summary>
        /// HLS
        /// </summary>
        [EnumMember(Value = "HLS")]
        HLS,

        /// <summary>
        /// CMAF
        /// </summary>
        [EnumMember(Value = "CMAF")]
        CMAF
    }
}
